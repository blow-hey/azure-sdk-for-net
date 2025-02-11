// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceLinker;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmServiceLinkerModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ServiceLinker.LinkerResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="targetService">
        /// The target service properties
        /// Please note <see cref="TargetServiceBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceInfo"/>, <see cref="ConfluentBootstrapServerInfo"/> and <see cref="ConfluentSchemaRegistryInfo"/>.
        /// </param>
        /// <param name="authInfo">
        /// The authentication type.
        /// Please note <see cref="AuthBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretAuthInfo"/>, <see cref="ServicePrincipalCertificateAuthInfo"/>, <see cref="ServicePrincipalSecretAuthInfo"/>, <see cref="SystemAssignedIdentityAuthInfo"/> and <see cref="UserAssignedIdentityAuthInfo"/>.
        /// </param>
        /// <param name="clientType"> The application client type. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="solutionType"> The VNet solution. </param>
        /// <param name="secretStoreKeyVaultId"> An option to store secret value in secure place. </param>
        /// <param name="scope"> connection scope in source service. </param>
        /// <returns> A new <see cref="ServiceLinker.LinkerResourceData"/> instance for mocking. </returns>
        public static LinkerResourceData LinkerResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, TargetServiceBaseInfo targetService = null, AuthBaseInfo authInfo = null, LinkerClientType? clientType = null, string provisioningState = null, VnetSolutionType? solutionType = null, ResourceIdentifier secretStoreKeyVaultId = null, string scope = null)
        {
            return new LinkerResourceData(id, name, resourceType, systemData, targetService, authInfo, clientType, provisioningState, solutionType != null ? new VnetSolution(solutionType, serializedAdditionalRawData: null) : null, secretStoreKeyVaultId != null ? new LinkerSecretStore(secretStoreKeyVaultId, serializedAdditionalRawData: null) : null, scope, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LinkerResourcePatch"/>. </summary>
        /// <param name="targetService">
        /// The target service properties
        /// Please note <see cref="TargetServiceBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceInfo"/>, <see cref="ConfluentBootstrapServerInfo"/> and <see cref="ConfluentSchemaRegistryInfo"/>.
        /// </param>
        /// <param name="authInfo">
        /// The authentication type.
        /// Please note <see cref="AuthBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretAuthInfo"/>, <see cref="ServicePrincipalCertificateAuthInfo"/>, <see cref="ServicePrincipalSecretAuthInfo"/>, <see cref="SystemAssignedIdentityAuthInfo"/> and <see cref="UserAssignedIdentityAuthInfo"/>.
        /// </param>
        /// <param name="clientType"> The application client type. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="solutionType"> The VNet solution. </param>
        /// <param name="secretStoreKeyVaultId"> An option to store secret value in secure place. </param>
        /// <param name="scope"> connection scope in source service. </param>
        /// <returns> A new <see cref="Models.LinkerResourcePatch"/> instance for mocking. </returns>
        public static LinkerResourcePatch LinkerResourcePatch(TargetServiceBaseInfo targetService = null, AuthBaseInfo authInfo = null, LinkerClientType? clientType = null, string provisioningState = null, VnetSolutionType? solutionType = null, ResourceIdentifier secretStoreKeyVaultId = null, string scope = null)
        {
            return new LinkerResourcePatch(targetService, authInfo, clientType, provisioningState, solutionType != null ? new VnetSolution(solutionType, serializedAdditionalRawData: null) : null, secretStoreKeyVaultId != null ? new LinkerSecretStore(secretStoreKeyVaultId, serializedAdditionalRawData: null) : null, scope, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LinkerValidateOperationResult"/>. </summary>
        /// <param name="resourceId"> Validated linker id. </param>
        /// <param name="status"> Validation operation status. </param>
        /// <param name="linkerName"> The linker name. </param>
        /// <param name="isConnectionAvailable"> A boolean value indicating whether the connection is available or not. </param>
        /// <param name="reportStartOn"> The start time of the validation report. </param>
        /// <param name="reportEndOn"> The end time of the validation report. </param>
        /// <param name="sourceId"> The resource id of the linker source application. </param>
        /// <param name="targetId"> The resource Id of target service. </param>
        /// <param name="authType"> The authentication type. </param>
        /// <param name="validationDetail"> The detail of validation result. </param>
        /// <returns> A new <see cref="Models.LinkerValidateOperationResult"/> instance for mocking. </returns>
        public static LinkerValidateOperationResult LinkerValidateOperationResult(ResourceIdentifier resourceId = null, string status = null, string linkerName = null, bool? isConnectionAvailable = null, DateTimeOffset? reportStartOn = null, DateTimeOffset? reportEndOn = null, ResourceIdentifier sourceId = null, ResourceIdentifier targetId = null, LinkerAuthType? authType = null, IEnumerable<LinkerValidationResultItemInfo> validationDetail = null)
        {
            validationDetail ??= new List<LinkerValidationResultItemInfo>();

            return new LinkerValidateOperationResult(resourceId, status, linkerName, isConnectionAvailable, reportStartOn, reportEndOn, sourceId, targetId, authType, validationDetail?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LinkerValidationResultItemInfo"/>. </summary>
        /// <param name="name"> The validation item name. </param>
        /// <param name="description"> The display name of validation item. </param>
        /// <param name="result"> The result of validation. </param>
        /// <param name="errorMessage"> The error message of validation result. </param>
        /// <param name="errorCode"> The error code of validation result. </param>
        /// <returns> A new <see cref="Models.LinkerValidationResultItemInfo"/> instance for mocking. </returns>
        public static LinkerValidationResultItemInfo LinkerValidationResultItemInfo(string name = null, string description = null, LinkerValidationResultStatus? result = null, string errorMessage = null, string errorCode = null)
        {
            return new LinkerValidationResultItemInfo(name, description, result, errorMessage, errorCode, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SourceConfigurationResult"/>. </summary>
        /// <param name="configurations"> The configuration properties for source resource. </param>
        /// <returns> A new <see cref="Models.SourceConfigurationResult"/> instance for mocking. </returns>
        public static SourceConfigurationResult SourceConfigurationResult(IEnumerable<SourceConfiguration> configurations = null)
        {
            configurations ??= new List<SourceConfiguration>();

            return new SourceConfigurationResult(configurations?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SourceConfiguration"/>. </summary>
        /// <param name="name"> The name of setting. </param>
        /// <param name="value"> The value of setting. </param>
        /// <returns> A new <see cref="Models.SourceConfiguration"/> instance for mocking. </returns>
        public static SourceConfiguration SourceConfiguration(string name = null, string value = null)
        {
            return new SourceConfiguration(name, value, serializedAdditionalRawData: null);
        }
    }
}
