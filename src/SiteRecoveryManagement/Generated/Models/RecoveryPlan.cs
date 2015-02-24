// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Recovery Plan object.
    /// </summary>
    public partial class RecoveryPlan : ServiceResourceBase
    {
        private string _replicationProvider;
        
        /// <summary>
        /// Required. Replication provider.
        /// </summary>
        public string ReplicationProvider
        {
            get { return this._replicationProvider; }
            set { this._replicationProvider = value; }
        }
        
        private string _serverId;
        
        /// <summary>
        /// Required. The ID of the source Server.
        /// </summary>
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }
        
        private string _targetServerId;
        
        /// <summary>
        /// Required. The ID of the target Server.
        /// </summary>
        public string TargetServerId
        {
            get { return this._targetServerId; }
            set { this._targetServerId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlan class.
        /// </summary>
        public RecoveryPlan()
        {
        }
    }
}
