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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// User profile.
    /// </summary>
    public partial class UserContract
    {
        private string _email;
        
        /// <summary>
        /// Optional. Gets or sets Email address.
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        
        private string _firstName;
        
        /// <summary>
        /// Optional. Gets or sets First name.
        /// </summary>
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        
        private IList<UserIdentityContract> _identities;
        
        /// <summary>
        /// Optional. Gets or sets Collection of user identities.
        /// </summary>
        public IList<UserIdentityContract> Identities
        {
            get { return this._identities; }
            set { this._identities = value; }
        }
        
        private string _idPath;
        
        /// <summary>
        /// Optional. Gets or sets User identifier path.
        /// </summary>
        public string IdPath
        {
            get { return this._idPath; }
            set { this._idPath = value; }
        }
        
        private string _lastName;
        
        /// <summary>
        /// Optional. Gets or sets Last name.
        /// </summary>
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
        
        private string _note;
        
        /// <summary>
        /// Optional. Gets or sets Administrator's note about given user.
        /// </summary>
        public string Note
        {
            get { return this._note; }
            set { this._note = value; }
        }
        
        private DateTime _registrationDate;
        
        /// <summary>
        /// Optional. Gets or sets Date of user registration.
        /// </summary>
        public DateTime RegistrationDate
        {
            get { return this._registrationDate; }
            set { this._registrationDate = value; }
        }
        
        private UserStateContract _state;
        
        /// <summary>
        /// Optional. Gets or sets User state.
        /// </summary>
        public UserStateContract State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UserContract class.
        /// </summary>
        public UserContract()
        {
            this.Identities = new LazyList<UserIdentityContract>();
        }
    }
}
