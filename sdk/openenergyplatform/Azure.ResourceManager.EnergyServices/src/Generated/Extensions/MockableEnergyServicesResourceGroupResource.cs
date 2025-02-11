// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EnergyServices;

namespace Azure.ResourceManager.EnergyServices.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableEnergyServicesResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableEnergyServicesResourceGroupResource"/> class for mocking. </summary>
        protected MockableEnergyServicesResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableEnergyServicesResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableEnergyServicesResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of EnergyServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of EnergyServiceResources and their operations over a EnergyServiceResource. </returns>
        public virtual EnergyServiceCollection GetEnergyServices()
        {
            return GetCachedClient(client => new EnergyServiceCollection(client, Id));
        }

        /// <summary>
        /// Returns oep resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OpenEnergyPlatform/energyServices/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnergyServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-04-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EnergyServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EnergyServiceResource>> GetEnergyServiceAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetEnergyServices().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns oep resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OpenEnergyPlatform/energyServices/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnergyServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-04-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EnergyServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<EnergyServiceResource> GetEnergyService(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetEnergyServices().Get(resourceName, cancellationToken);
        }
    }
}
