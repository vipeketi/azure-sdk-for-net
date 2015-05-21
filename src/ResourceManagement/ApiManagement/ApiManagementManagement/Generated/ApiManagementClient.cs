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
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// .Net client wrapper for the REST API for Azure ApiManagement Service
    /// </summary>
    public partial class ApiManagementClient : ServiceClient<ApiManagementClient>, IApiManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private IApiOperationPolicyOperations _apiOperationPolicy;
        
        /// <summary>
        /// Operations for managing API Operation Policy.
        /// </summary>
        public virtual IApiOperationPolicyOperations ApiOperationPolicy
        {
            get { return this._apiOperationPolicy; }
        }
        
        private IApiOperationsOperations _apiOperations;
        
        /// <summary>
        /// Operations for managing API Operations.
        /// </summary>
        public virtual IApiOperationsOperations ApiOperations
        {
            get { return this._apiOperations; }
        }
        
        private IApiPolicyOperations _apiPolicy;
        
        /// <summary>
        /// Operations for managing API Policy.
        /// </summary>
        public virtual IApiPolicyOperations ApiPolicy
        {
            get { return this._apiPolicy; }
        }
        
        private IApiProductsOperations _apiProducts;
        
        /// <summary>
        /// Operations for listing API associated Products.
        /// </summary>
        public virtual IApiProductsOperations ApiProducts
        {
            get { return this._apiProducts; }
        }
        
        private IApisOperations _apis;
        
        /// <summary>
        /// Operations for managing APIs.
        /// </summary>
        public virtual IApisOperations Apis
        {
            get { return this._apis; }
        }
        
        private IAuthorizationServersOperations _authorizationServers;
        
        /// <summary>
        /// Operations for managing Authorization Servers.
        /// </summary>
        public virtual IAuthorizationServersOperations AuthorizationServers
        {
            get { return this._authorizationServers; }
        }
        
        private ICertificatesOperations _certificates;
        
        /// <summary>
        /// Operations for managing Certificates.
        /// </summary>
        public virtual ICertificatesOperations Certificates
        {
            get { return this._certificates; }
        }
        
        private IGroupsOperations _groups;
        
        /// <summary>
        /// Operations for managing Groups.
        /// </summary>
        public virtual IGroupsOperations Groups
        {
            get { return this._groups; }
        }
        
        private IGroupUsersOperations _groupUsers;
        
        /// <summary>
        /// Operations for managing Group Users (list, add, remove users within
        /// a group).
        /// </summary>
        public virtual IGroupUsersOperations GroupUsers
        {
            get { return this._groupUsers; }
        }
        
        private IPolicySnippetsOperations _policySnippents;
        
        /// <summary>
        /// Operations for managing Policy Snippets.
        /// </summary>
        public virtual IPolicySnippetsOperations PolicySnippents
        {
            get { return this._policySnippents; }
        }
        
        private IProductApisOperations _productApis;
        
        /// <summary>
        /// Operations for managing Product APIs.
        /// </summary>
        public virtual IProductApisOperations ProductApis
        {
            get { return this._productApis; }
        }
        
        private IProductGroupsOperations _productGroups;
        
        /// <summary>
        /// Operations for managing Product Groups.
        /// </summary>
        public virtual IProductGroupsOperations ProductGroups
        {
            get { return this._productGroups; }
        }
        
        private IProductPolicyOperations _productPolicy;
        
        /// <summary>
        /// Operations for managing Product Policy.
        /// </summary>
        public virtual IProductPolicyOperations ProductPolicy
        {
            get { return this._productPolicy; }
        }
        
        private IProductsOperations _products;
        
        /// <summary>
        /// Operations for managing Products.
        /// </summary>
        public virtual IProductsOperations Products
        {
            get { return this._products; }
        }
        
        private IProductSubscriptionsOperations _productSubscriptions;
        
        /// <summary>
        /// Operations for managing Product Subscriptions.
        /// </summary>
        public virtual IProductSubscriptionsOperations ProductSubscriptions
        {
            get { return this._productSubscriptions; }
        }
        
        private IRegionsOperations _regions;
        
        /// <summary>
        /// Operations for managing Regions.
        /// </summary>
        public virtual IRegionsOperations Regions
        {
            get { return this._regions; }
        }
        
        private IReportsOperations _reports;
        
        /// <summary>
        /// Operations for managing Reports.
        /// </summary>
        public virtual IReportsOperations Reports
        {
            get { return this._reports; }
        }
        
        private IResourceProviderOperations _resourceProvider;
        
        /// <summary>
        /// Operations for managing Api Management service provisioning
        /// (create/remove, backup/restore, scale, etc.).
        /// </summary>
        public virtual IResourceProviderOperations ResourceProvider
        {
            get { return this._resourceProvider; }
        }
        
        private ISubscriptionsOperations _subscriptions;
        
        /// <summary>
        /// Operations for managing Subscriptions.
        /// </summary>
        public virtual ISubscriptionsOperations Subscriptions
        {
            get { return this._subscriptions; }
        }
        
        private ITenantPolicyOperations _tenantPolicy;
        
        /// <summary>
        /// Operations for managing Tenant Policy.
        /// </summary>
        public virtual ITenantPolicyOperations TenantPolicy
        {
            get { return this._tenantPolicy; }
        }
        
        private IUserApplicationsOperations _userApplications;
        
        /// <summary>
        /// Operations for managing User Applications.
        /// </summary>
        public virtual IUserApplicationsOperations UserApplications
        {
            get { return this._userApplications; }
        }
        
        private IUserGroupsOperations _userGroups;
        
        /// <summary>
        /// Operations for managing User Groups.
        /// </summary>
        public virtual IUserGroupsOperations UserGroups
        {
            get { return this._userGroups; }
        }
        
        private IUserIdentitiesOperations _userIdentities;
        
        /// <summary>
        /// Operations for managing User Identities.
        /// </summary>
        public virtual IUserIdentitiesOperations UserIdentities
        {
            get { return this._userIdentities; }
        }
        
        private IUsersOperations _users;
        
        /// <summary>
        /// Operations for managing Users.
        /// </summary>
        public virtual IUsersOperations Users
        {
            get { return this._users; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        public ApiManagementClient()
            : base()
        {
            this._apiOperationPolicy = new ApiOperationPolicyOperations(this);
            this._apiOperations = new ApiOperationsOperations(this);
            this._apiPolicy = new ApiPolicyOperations(this);
            this._apiProducts = new ApiProductsOperations(this);
            this._apis = new ApisOperations(this);
            this._authorizationServers = new AuthorizationServersOperations(this);
            this._certificates = new CertificatesOperations(this);
            this._groups = new GroupsOperations(this);
            this._groupUsers = new GroupUsersOperations(this);
            this._policySnippents = new PolicySnippetsOperations(this);
            this._productApis = new ProductApisOperations(this);
            this._productGroups = new ProductGroupsOperations(this);
            this._productPolicy = new ProductPolicyOperations(this);
            this._products = new ProductsOperations(this);
            this._productSubscriptions = new ProductSubscriptionsOperations(this);
            this._regions = new RegionsOperations(this);
            this._reports = new ReportsOperations(this);
            this._resourceProvider = new ResourceProviderOperations(this);
            this._subscriptions = new SubscriptionsOperations(this);
            this._tenantPolicy = new TenantPolicyOperations(this);
            this._userApplications = new UserApplicationsOperations(this);
            this._userGroups = new UserGroupsOperations(this);
            this._userIdentities = new UserIdentitiesOperations(this);
            this._users = new UsersOperations(this);
            this._apiVersion = "2014-02-14";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public ApiManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public ApiManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public ApiManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._apiOperationPolicy = new ApiOperationPolicyOperations(this);
            this._apiOperations = new ApiOperationsOperations(this);
            this._apiPolicy = new ApiPolicyOperations(this);
            this._apiProducts = new ApiProductsOperations(this);
            this._apis = new ApisOperations(this);
            this._authorizationServers = new AuthorizationServersOperations(this);
            this._certificates = new CertificatesOperations(this);
            this._groups = new GroupsOperations(this);
            this._groupUsers = new GroupUsersOperations(this);
            this._policySnippents = new PolicySnippetsOperations(this);
            this._productApis = new ProductApisOperations(this);
            this._productGroups = new ProductGroupsOperations(this);
            this._productPolicy = new ProductPolicyOperations(this);
            this._products = new ProductsOperations(this);
            this._productSubscriptions = new ProductSubscriptionsOperations(this);
            this._regions = new RegionsOperations(this);
            this._reports = new ReportsOperations(this);
            this._resourceProvider = new ResourceProviderOperations(this);
            this._subscriptions = new SubscriptionsOperations(this);
            this._tenantPolicy = new TenantPolicyOperations(this);
            this._userApplications = new UserApplicationsOperations(this);
            this._userGroups = new UserGroupsOperations(this);
            this._userIdentities = new UserIdentitiesOperations(this);
            this._users = new UsersOperations(this);
            this._apiVersion = "2014-02-14";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public ApiManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public ApiManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// ApiManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of ApiManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<ApiManagementClient> client)
        {
            base.Clone(client);
            
            if (client is ApiManagementClient)
            {
                ApiManagementClient clonedClient = ((ApiManagementClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// Parse enum values for type BearerTokenSendingMethodsContract.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static BearerTokenSendingMethodsContract ParseBearerTokenSendingMethodsContract(string value)
        {
            if ("authorizationHeader".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return BearerTokenSendingMethodsContract.AuthorizationHeader;
            }
            if ("query".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return BearerTokenSendingMethodsContract.Query;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type BearerTokenSendingMethodsContract to a
        /// string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string BearerTokenSendingMethodsContractToString(BearerTokenSendingMethodsContract value)
        {
            if (value == BearerTokenSendingMethodsContract.AuthorizationHeader)
            {
                return "authorizationHeader";
            }
            if (value == BearerTokenSendingMethodsContract.Query)
            {
                return "query";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type GrantTypesContract.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static GrantTypesContract ParseGrantTypesContract(string value)
        {
            if ("authorizationCode".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return GrantTypesContract.AuthorizationCode;
            }
            if ("implicit".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return GrantTypesContract.Implicit;
            }
            if ("resourceOwnerPassword".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return GrantTypesContract.ResourceOwnerPassword;
            }
            if ("clientCredentials".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return GrantTypesContract.ClientCredentials;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type GrantTypesContract to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string GrantTypesContractToString(GrantTypesContract value)
        {
            if (value == GrantTypesContract.AuthorizationCode)
            {
                return "authorizationCode";
            }
            if (value == GrantTypesContract.Implicit)
            {
                return "implicit";
            }
            if (value == GrantTypesContract.ResourceOwnerPassword)
            {
                return "resourceOwnerPassword";
            }
            if (value == GrantTypesContract.ClientCredentials)
            {
                return "clientCredentials";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type MethodContract.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static MethodContract ParseMethodContract(string value)
        {
            if ("HEAD".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return MethodContract.Head;
            }
            if ("OPTIONS".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return MethodContract.Options;
            }
            if ("TRACE".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return MethodContract.Trace;
            }
            if ("GET".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return MethodContract.Get;
            }
            if ("POST".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return MethodContract.Post;
            }
            if ("PUT".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return MethodContract.Put;
            }
            if ("PATCH".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return MethodContract.Patch;
            }
            if ("DELETE".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return MethodContract.Delete;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type MethodContract to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string MethodContractToString(MethodContract value)
        {
            if (value == MethodContract.Head)
            {
                return "HEAD";
            }
            if (value == MethodContract.Options)
            {
                return "OPTIONS";
            }
            if (value == MethodContract.Trace)
            {
                return "TRACE";
            }
            if (value == MethodContract.Get)
            {
                return "GET";
            }
            if (value == MethodContract.Post)
            {
                return "POST";
            }
            if (value == MethodContract.Put)
            {
                return "PUT";
            }
            if (value == MethodContract.Patch)
            {
                return "PATCH";
            }
            if (value == MethodContract.Delete)
            {
                return "DELETE";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type ReportsAggregation.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static ReportsAggregation ParseReportsAggregation(string value)
        {
            if ("byApi".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ReportsAggregation.ByApi;
            }
            if ("byGeo".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ReportsAggregation.ByGeo;
            }
            if ("byOperation".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ReportsAggregation.ByOperation;
            }
            if ("byProduct".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ReportsAggregation.ByProduct;
            }
            if ("bySubscription".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ReportsAggregation.BySubscription;
            }
            if ("byTime".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ReportsAggregation.ByTime;
            }
            if ("byUser".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ReportsAggregation.ByUser;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type ReportsAggregation to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string ReportsAggregationToString(ReportsAggregation value)
        {
            if (value == ReportsAggregation.ByApi)
            {
                return "byApi";
            }
            if (value == ReportsAggregation.ByGeo)
            {
                return "byGeo";
            }
            if (value == ReportsAggregation.ByOperation)
            {
                return "byOperation";
            }
            if (value == ReportsAggregation.ByProduct)
            {
                return "byProduct";
            }
            if (value == ReportsAggregation.BySubscription)
            {
                return "bySubscription";
            }
            if (value == ReportsAggregation.ByTime)
            {
                return "byTime";
            }
            if (value == ReportsAggregation.ByUser)
            {
                return "byUser";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
