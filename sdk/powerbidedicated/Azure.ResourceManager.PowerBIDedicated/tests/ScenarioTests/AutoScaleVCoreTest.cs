// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Core;
using NUnit.Framework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.PowerBIDedicated.Models;
using NUnit.Framework.Constraints;
using System.Diagnostics.Metrics;

namespace Azure.ResourceManager.PowerBIDedicated.Tests
{
    public class AutoScaleVCoreTest: PowerBIDedicatedManagementTestBase
    {
        private readonly AzureLocation _location = AzureLocation.EastUS;
        public AutoScaleVCoreTest(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        { }

        [Test]
        public async Task AutoScaleVCoreTestCase()
        {
            var _subscription =await Client.GetDefaultSubscriptionAsync();
            var _resourceGroup = await CreateResourceGroup(_subscription, "AutoScaleVC-Test", _location);
            var _collection = _resourceGroup.GetAutoScaleVCores();

            //AutoScaleVCoreCollection_Create
            var vcoreName = Recording.GenerateAssetName("autoScaleVC");
            var vcoreData = new AutoScaleVCoreData(_location, new AutoScaleVCoreSku("AutoScale")
            {
                Tier = VCoreSkuTier.AutoScale
            })
            {
                Tags =
                {
                    ["key1"] = "value"
                },
                CapacityLimit = 10,
            };
            var vcoreResource = (await _collection.CreateOrUpdateAsync(WaitUntil.Completed, vcoreName,vcoreData)).Value;
            Assert.IsNotNull(vcoreResource);
            Assert.AreEqual(vcoreName, vcoreResource.Data.Name);

            //AutoScaleVCoreCollection_Exist
            var exist = await _collection.ExistsAsync(vcoreName);
            Assert.IsTrue(exist);

            //AutoScaleVCoreCollection_Get
            var getResult = (await _collection.GetAsync(vcoreName)).Value;
            Assert.IsNotNull(getResult);
            Assert.AreEqual(getResult.Data.Id,vcoreResource.Data.Id);
            Assert.AreEqual(getResult.Data.Name, vcoreResource.Data.Name);

            //AutoScaleVCoreCollection_GetAll
            var vcoreName2 = Recording.GenerateAssetName("autoScaleVC2nd");
            var vcoreData2 = new AutoScaleVCoreData(_location, new AutoScaleVCoreSku("AutoScale"));
            var vcoreResource2 = (await _collection.CreateOrUpdateAsync(WaitUntil.Completed, vcoreName2, vcoreData2)).Value;
            var getList =  _collection.GetAllAsync().ToEnumerableAsync().Result.ToList();
            Assert.IsNotEmpty(getList);
            Assert.IsTrue(getList.Count >= 2);
            Assert.IsTrue(getList.Exists(item => item.Data.Name == vcoreResource.Data.Name));
            Assert.IsTrue(getList.Exists(item => item.Data.Name == vcoreResource2.Data.Name));

            //AutoScaleVCoreCollection_GetIfExists
            var getIfExists = (await _collection.GetIfExistsAsync(vcoreName)).Value;
            Assert.IsNotNull(getIfExists);
            Assert.AreEqual(vcoreResource.Data.Name, getIfExists.Data.Name);
            Assert.AreEqual(vcoreResource.Data.Id, getIfExists.Data.Id);

            //AutoScaleVCoreResource_CreateResourceIdentifier and Get
            var resourceId = AutoScaleVCoreResource.CreateResourceIdentifier(_subscription.Data.SubscriptionId, _resourceGroup.Data.Name, vcoreResource.Data.Name);
            var identifierResource = Client.GetAutoScaleVCoreResource(resourceId);
            Assert.IsNotNull(identifierResource);
            var verify = (await identifierResource.GetAsync()).Value; //Get
            Assert.IsNotNull(verify);
            Assert.AreEqual(vcoreResource.Data.Id, verify.Data.Id);
            Assert.AreEqual(vcoreResource.Data.Name, verify.Data.Name);

            //AutoScaleVCoreResource_TagsOperation
            var addTag = (await vcoreResource.AddTagAsync("key2", "AddTags")).Value; //AddTags
            Assert.IsNotEmpty(addTag.Data.Tags);
            Assert.IsTrue(addTag.Data.Tags.ContainsKey("key2"));
            var setDic = new Dictionary<string, string>() //SetTags
            {
                ["key1"] = "AutoScaleVCoreTest",
                ["key2"] = "TagOperation",
                ["key3"] = "SetTagsTest"
            };
            var setTag = (await vcoreResource.SetTagsAsync(setDic)).Value;
            Assert.AreEqual(setTag.Data.Tags["key1"], setDic["key1"]);
            Assert.IsTrue(setTag.Data.Tags["key2"] != "AddTags");
            string removeKey = "key3";
            var removeTag = await vcoreResource.RemoveTagAsync(removeKey); //RemoveTags
            Assert.IsFalse(removeTag.Value.Data.Tags.ContainsKey(removeKey));

            //AutoScaleVCoreResource_Update
            var updateData = new AutoScaleVCorePatch()
            {
                Tags =
                {
                    ["key4"] = "updateTest",
                    ["key5"] = "testdata"
                }
            };
            var update = (await vcoreResource.UpdateAsync(updateData)).Value;
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
            var delete = await vcoreResource.DeleteAsync(WaitUntil.Completed);
            Assert.IsTrue(delete.HasCompleted);
            Assert.IsFalse(await _collection.ExistsAsync(vcoreName));
            await _resourceGroup.DeleteAsync(WaitUntil.Completed);
        }
    }
}
