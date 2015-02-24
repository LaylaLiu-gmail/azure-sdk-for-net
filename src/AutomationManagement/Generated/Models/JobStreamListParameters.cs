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
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the list job stream's stream items operation.
    /// </summary>
    public partial class JobStreamListParameters : ParametersWithSkipToken
    {
        private string _streamType;
        
        /// <summary>
        /// Optional. The type of the job stream.
        /// </summary>
        public string StreamType
        {
            get { return this._streamType; }
            set { this._streamType = value; }
        }
        
        private string _time;
        
        /// <summary>
        /// Optional. Use the time filter to retrieve stream records created
        /// after this time. The value should be a datetime string in UTC
        /// format as defined in ISO 8601. For example,
        /// 2014-09-25T17:49:17.2252204Z
        /// </summary>
        public string Time
        {
            get { return this._time; }
            set { this._time = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobStreamListParameters class.
        /// </summary>
        public JobStreamListParameters()
        {
        }
    }
}
