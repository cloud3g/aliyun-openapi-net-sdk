/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateCatalogRequest : RpcAcsRequest<CreateCatalogResponse>
    {
        public CreateCatalogRequest()
            : base("CloudAPI", "2016-07-14", "CreateCatalog")
        {
        }

		private string catalogName;

		private string description;

		private string parentId;

		public string CatalogName
		{
			get
			{
				return catalogName;
			}
			set	
			{
				catalogName = value;
				DictionaryUtil.Add(QueryParameters, "CatalogName", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string ParentId
		{
			get
			{
				return parentId;
			}
			set	
			{
				parentId = value;
				DictionaryUtil.Add(QueryParameters, "ParentId", value);
			}
		}

        public override CreateCatalogResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateCatalogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}