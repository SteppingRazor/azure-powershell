// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure Key Vault linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureKeyVault")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureKeyVaultLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureKeyVaultLinkedService
        /// class.
        /// </summary>
        public PSAzureKeyVaultLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the base URL of the Azure Key Vault. e.g.
        /// https://myakv.vault.azure.net Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.baseUrl")]
        public object BaseUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (BaseUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BaseUrl");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AzureKeyVaultLinkedService(this.BaseUrl);
            SetProperties(linkedService);
            return linkedService;
        }
    }
}

