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
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.RemoteApp;

namespace Microsoft.WindowsAzure.Management.RemoteApp
{
    /// <summary>
    /// RmoteApp management client
    /// </summary>
    public partial interface IRemoteAppManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// RDFE namespace for accessing test environments.
        /// </summary>
        string RdfeNamespace
        {
            get; set; 
        }
        
        /// <summary>
        /// Operations related to RemoteApp account.
        /// </summary>
        IAccountsOperations Account
        {
            get; 
        }
        
        /// <summary>
        /// RemoteApp collection operations.
        /// </summary>
        ICollectionOperations Collections
        {
            get; 
        }
        
        /// <summary>
        /// Operations for long-running operation results
        /// </summary>
        IOperationResultOperations OperationResults
        {
            get; 
        }
        
        /// <summary>
        /// RemoteApp principal operations.
        /// </summary>
        IPrincipalOperations Principals
        {
            get; 
        }
        
        /// <summary>
        /// Operations related to publishing.
        /// </summary>
        IPublishingOperations Publishing
        {
            get; 
        }
        
        /// <summary>
        /// Operations to create, modify, list, and delete template images.
        /// </summary>
        ITemplateImageOperations TemplateImages
        {
            get; 
        }
        
        /// <summary>
        /// RemoteApp virtual network operations.
        /// </summary>
        IVNetOperations VNet
        {
            get; 
        }
    }
}
