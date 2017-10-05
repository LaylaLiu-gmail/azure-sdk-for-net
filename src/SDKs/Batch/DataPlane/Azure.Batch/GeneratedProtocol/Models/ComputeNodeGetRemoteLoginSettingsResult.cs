// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The remote login settings for a compute node.
    /// </summary>
    public partial class ComputeNodeGetRemoteLoginSettingsResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComputeNodeGetRemoteLoginSettingsResult class.
        /// </summary>
        public ComputeNodeGetRemoteLoginSettingsResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComputeNodeGetRemoteLoginSettingsResult class.
        /// </summary>
        /// <param name="remoteLoginIPAddress">The IP address used for remote
        /// login to the compute node.</param>
        /// <param name="remoteLoginPort">The port used for remote login to the
        /// compute node.</param>
        public ComputeNodeGetRemoteLoginSettingsResult(string remoteLoginIPAddress, int remoteLoginPort)
        {
            RemoteLoginIPAddress = remoteLoginIPAddress;
            RemoteLoginPort = remoteLoginPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IP address used for remote login to the compute
        /// node.
        /// </summary>
        [JsonProperty(PropertyName = "remoteLoginIPAddress")]
        public string RemoteLoginIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the port used for remote login to the compute node.
        /// </summary>
        [JsonProperty(PropertyName = "remoteLoginPort")]
        public int RemoteLoginPort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RemoteLoginIPAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RemoteLoginIPAddress");
            }
        }
    }
}