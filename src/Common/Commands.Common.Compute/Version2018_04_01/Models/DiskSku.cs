// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version_2018_04.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The disks sku name. Can be Standard_LRS or Premium_LRS.
    /// </summary>
    public partial class DiskSku
    {
        /// <summary>
        /// Initializes a new instance of the DiskSku class.
        /// </summary>
        public DiskSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskSku class.
        /// </summary>
        /// <param name="name">The sku name. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS'</param>
        /// <param name="tier">The sku tier.</param>
        public DiskSku(string name = default(string), string tier = default(string))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sku name. Possible values include: 'Standard_LRS',
        /// 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the sku tier.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; private set; }

    }
}
