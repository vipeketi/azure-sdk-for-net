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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.RemoteApp;
using Microsoft.WindowsAzure.Management.RemoteApp.Models;

namespace Microsoft.WindowsAzure.Management.RemoteApp
{
    /// <summary>
    /// RmoteApp management client
    /// </summary>
    public static partial class PublishingOperationsExtensions
    {
        /// <summary>
        /// Gets the details of a published application with given alias (short
        /// unique name) from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='alias'>
        /// Required. Alias of published application
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplication operation.
        /// </returns>
        public static GetPublishedApplicationResult Get(this IPublishingOperations operations, string collectionName, string alias)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).GetAsync(collectionName, alias);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the details of a published application with given alias (short
        /// unique name) from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='alias'>
        /// Required. Alias of published application
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplication operation.
        /// </returns>
        public static Task<GetPublishedApplicationResult> GetAsync(this IPublishingOperations operations, string collectionName, string alias)
        {
            return operations.GetAsync(collectionName, alias, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the list of details for all published applications from the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplicationList operation.
        /// </returns>
        public static GetPublishedApplicationListResult List(this IPublishingOperations operations, string collectionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).ListAsync(collectionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the list of details for all published applications from the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplicationList operation.
        /// </returns>
        public static Task<GetPublishedApplicationListResult> ListAsync(this IPublishingOperations operations, string collectionName)
        {
            return operations.ListAsync(collectionName, CancellationToken.None);
        }
        
        /// <summary>
        /// Sets a published application matching the given alias (short unique
        /// name) in the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='alias'>
        /// Required. Alias of published application
        /// </param>
        /// <param name='applicationDetails'>
        /// Required. New details for the application
        /// </param>
        /// <returns>
        /// Definition for result of ModifyApplicaton operation.
        /// </returns>
        public static ModifyApplicationResult ModifyApplication(this IPublishingOperations operations, string collectionName, string alias, ApplicationDetailsParameter applicationDetails)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).ModifyApplicationAsync(collectionName, alias, applicationDetails);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Sets a published application matching the given alias (short unique
        /// name) in the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='alias'>
        /// Required. Alias of published application
        /// </param>
        /// <param name='applicationDetails'>
        /// Required. New details for the application
        /// </param>
        /// <returns>
        /// Definition for result of ModifyApplicaton operation.
        /// </returns>
        public static Task<ModifyApplicationResult> ModifyApplicationAsync(this IPublishingOperations operations, string collectionName, string alias, ApplicationDetailsParameter applicationDetails)
        {
            return operations.ModifyApplicationAsync(collectionName, alias, applicationDetails, CancellationToken.None);
        }
        
        /// <summary>
        /// Publishes remote applications with given application details in the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='applicationDetailsList'>
        /// Required. List of publishing details
        /// </param>
        /// <returns>
        /// Definition for result of PublishApplications operation.
        /// </returns>
        public static PublishApplicationsResult PublishApplications(this IPublishingOperations operations, string collectionName, ApplicationDetailsListParameter applicationDetailsList)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).PublishApplicationsAsync(collectionName, applicationDetailsList);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Publishes remote applications with given application details in the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='applicationDetailsList'>
        /// Required. List of publishing details
        /// </param>
        /// <returns>
        /// Definition for result of PublishApplications operation.
        /// </returns>
        public static Task<PublishApplicationsResult> PublishApplicationsAsync(this IPublishingOperations operations, string collectionName, ApplicationDetailsListParameter applicationDetailsList)
        {
            return operations.PublishApplicationsAsync(collectionName, applicationDetailsList, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a start menu application details for the given id from the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='applicationId'>
        /// Required. Start menu application Id
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplication operation.
        /// </returns>
        public static GetStartMenuApplicationResult StartMenuApplication(this IPublishingOperations operations, string collectionName, string applicationId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).StartMenuApplicationAsync(collectionName, applicationId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a start menu application details for the given id from the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='applicationId'>
        /// Required. Start menu application Id
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplication operation.
        /// </returns>
        public static Task<GetStartMenuApplicationResult> StartMenuApplicationAsync(this IPublishingOperations operations, string collectionName, string applicationId)
        {
            return operations.StartMenuApplicationAsync(collectionName, applicationId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the list of all start menu applications from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplicationList operation.
        /// </returns>
        public static GetStartMenuApplicationListResult StartMenuApplicationList(this IPublishingOperations operations, string collectionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).StartMenuApplicationListAsync(collectionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the list of all start menu applications from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplicationList operation.
        /// </returns>
        public static Task<GetStartMenuApplicationListResult> StartMenuApplicationListAsync(this IPublishingOperations operations, string collectionName)
        {
            return operations.StartMenuApplicationListAsync(collectionName, CancellationToken.None);
        }
        
        /// <summary>
        /// Unpublishes published applications matching the given list of
        /// application aliases (short unique names) from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='aliasesList'>
        /// Required. List of application aliases to be unpublished
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishApplications operation.
        /// </returns>
        public static UnpublishApplicationsResult Unpublish(this IPublishingOperations operations, string collectionName, AliasesListParameter aliasesList)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).UnpublishAsync(collectionName, aliasesList);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unpublishes published applications matching the given list of
        /// application aliases (short unique names) from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <param name='aliasesList'>
        /// Required. List of application aliases to be unpublished
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishApplications operation.
        /// </returns>
        public static Task<UnpublishApplicationsResult> UnpublishAsync(this IPublishingOperations operations, string collectionName, AliasesListParameter aliasesList)
        {
            return operations.UnpublishAsync(collectionName, aliasesList, CancellationToken.None);
        }
        
        /// <summary>
        /// Unpublishes all published applications from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishApplications operation.
        /// </returns>
        public static UnpublishApplicationsResult UnpublishAll(this IPublishingOperations operations, string collectionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).UnpublishAllAsync(collectionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unpublishes all published applications from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.IPublishingOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. Collection Name
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishApplications operation.
        /// </returns>
        public static Task<UnpublishApplicationsResult> UnpublishAllAsync(this IPublishingOperations operations, string collectionName)
        {
            return operations.UnpublishAllAsync(collectionName, CancellationToken.None);
        }
    }
}
