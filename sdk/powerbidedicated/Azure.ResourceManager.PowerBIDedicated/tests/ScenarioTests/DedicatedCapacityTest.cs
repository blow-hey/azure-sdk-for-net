// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Core;
using Azure.ResourceManager.PowerBIDedicated.Models;
using NUnit.Framework;
using System.Net;

namespace Azure.ResourceManager.PowerBIDedicated.Tests
{
    public class DedicatedCapacityTest: PowerBIDedicatedManagementTestBase
    {
        private readonly AzureLocation _location = AzureLocation.EastUS;
        public DedicatedCapacityTest(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        { }

        [Test]
        public async Task DedicatedCapacityTestCase()
        {
            var _subscription =await Client.GetDefaultSubscriptionAsync();
            var _resourceGroup = await CreateResourceGroup(_subscription, "DedicatedCapacity-Test", _location);
            var _collection = _resourceGroup.GetDedicatedCapacities();

            //AutoScaleVCoreCollection_Create
            var deCapacityName = Recording.GenerateAssetName("decapacity");
            var deCapacityData = new DedicatedCapacityData(_location, new CapacitySku("A1")
            {
                Tier = CapacitySkuTier.PbieAzure,
            })
            {
                Tags =
                {
                    ["key1"] = "value"
                },
                AdministrationMembers =
                {
                    "@microsoft.com"  //An email address that actually exists and can add user permissions is required
                }
            };
            var deCapacity = (await _collection.CreateOrUpdateAsync(WaitUntil.Completed, deCapacityName, deCapacityData)).Value;
            Assert.IsNotNull(deCapacity);
            Assert.AreEqual(deCapacityName, deCapacity.Data.Name);

            //AutoScaleVCoreCollection_Exist
            var exist = await _collection.ExistsAsync(deCapacityName);
            Assert.IsTrue(exist);

            //AutoScaleVCoreCollection_Get
            var getResult = (await _collection.GetAsync(deCapacityName)).Value;
            Assert.IsNotNull(getResult);
            Assert.AreEqual(getResult.Data.Id, deCapacity.Data.Id);
            Assert.AreEqual(getResult.Data.Name, deCapacity.Data.Name);

            //AutoScaleVCoreCollection_GetAll
            var deCapacityName2 = Recording.GenerateAssetName("decapacity2nd");
            var deCapacityData2 = new DedicatedCapacityData(_location, new CapacitySku("A1")
            {
                Tier = CapacitySkuTier.PbieAzure,
            })
            {
                AdministrationMembers =
                {
                    "v-chuntongli@microsoft.com"
                }
            };
            var deCapacity2 = (await _collection.CreateOrUpdateAsync(WaitUntil.Completed, deCapacityName2, deCapacityData2)).Value;
            var getList = _collection.GetAllAsync().ToEnumerableAsync().Result.ToList();
            Assert.IsNotEmpty(getList);
            Assert.IsTrue(getList.Count >= 2);
            Assert.IsTrue(getList.Exists(item => item.Data.Name == deCapacity.Data.Name));
            Assert.IsTrue(getList.Exists(item => item.Data.Name == deCapacity2.Data.Name));

            //AutoScaleVCoreCollection_GetIfExists
            var getIfExists = (await _collection.GetIfExistsAsync(deCapacityName)).Value;
            Assert.IsNotNull(getIfExists);
            Assert.AreEqual(deCapacity.Data.Name, getIfExists.Data.Name);
            Assert.AreEqual(deCapacity.Data.Id, getIfExists.Data.Id);

            //AutoScaleVCoreResource_CreateResourceIdentifier and Get
            var resourceId = DedicatedCapacityResource.CreateResourceIdentifier(_subscription.Data.SubscriptionId, _resourceGroup.Data.Name, deCapacity.Data.Name);
            var identifierResource = Client.GetDedicatedCapacityResource(resourceId);
            Assert.IsNotNull(identifierResource);
            var verify = (await identifierResource.GetAsync()).Value; //Get
            Assert.IsNotNull(verify);
            Assert.AreEqual(deCapacity.Data.Id, verify.Data.Id);
            Assert.AreEqual(deCapacity.Data.Name, verify.Data.Name);

            //AutoScaleVCoreResource_TagsOperation
            var addTag = (await deCapacity.AddTagAsync("key2", "AddTags")).Value; //AddTags
            Assert.IsNotEmpty(addTag.Data.Tags);
            Assert.IsTrue(addTag.Data.Tags.ContainsKey("key2"));
            var setDic = new Dictionary<string, string>() //SetTags
            {
                ["key1"] = "AutoScaleVCoreTest",
                ["key2"] = "TagOperation",
                ["key3"] = "SetTagsTest"
            };
            var setTag = (await deCapacity.SetTagsAsync(setDic)).Value;
            Assert.AreEqual(setTag.Data.Tags["key1"], setDic["key1"]);
            Assert.IsTrue(setTag.Data.Tags["key2"] != "AddTags");
            string removeKey = "key3";
            var removeTag = await deCapacity.RemoveTagAsync(removeKey); //RemoveTags
            Assert.IsFalse(removeTag.Value.Data.Tags.ContainsKey(removeKey));

            //AutoScaleVCoreResource_Update
            var updateData = new DedicatedCapacityPatch()
            {
                Tags =
                {
                    ["key4"] = "updateTest",
                    ["key5"] = "testdata"
                }
            };
            var update = (await deCapacity.UpdateAsync(WaitUntil.Completed,updateData)).Value;
            Assert.IsNotNull(update);
            var verifyDic = new Dictionary<string, string>();
            foreach (var item in update.Data.Tags)
            {
                verifyDic.Add(item.Key, item.Value);
            }
            foreach (var item in updateData.Tags)
            {
                Assert.IsTrue(verifyDic.ContainsKey(item.Key));
                Assert.IsTrue(verifyDic.ContainsValue(item.Value));
            }

            //AutoScaleVCoreResource_Delete
            var delete = await deCapacity.DeleteAsync(WaitUntil.Completed);
            Assert.IsTrue(delete.HasCompleted);
            Assert.IsFalse(await _collection.ExistsAsync(deCapacityName));
            await _resourceGroup.DeleteAsync(WaitUntil.Completed);
        }
    }
}
