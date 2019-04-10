/****************************************************
 * 
 * 广联达软件股份有限责任公司版权所有.
 * 
 *****************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using GTP.Runtime.Biz.Service;
using GTP.Runtime.Core.Loaders;
using GTP.Runtime.DataObject;
using GTP.Runtime.DataObject.Entity;
using GTP.Runtime.DataObject.Entity.Collections;
using GTP.Runtime.DataObject.Extensions;
namespace GTP.PortalDataService.WorkFlow.Entities
{
	/// <summary>
	/// 数据字典
	/// </summary>
	[Serializable]
	[Generated]
    [Version("1.0.0.0")]
    [Business("GTP.PortalDataService.WorkFlow.DictPoco", MetadataRuntimeType.Poco)]
	public class DictPoco : SimpleEntity
	{
		public const string P_Key = "Key";
		public const string P_Value = "Value";
		public const string METADATA_NAME = "GTP.PortalDataService.WorkFlow.DictPoco";
		
		public DictPoco(string typeName)
			: base(typeName)
		{
		}

		public DictPoco()
			: base(METADATA_NAME)
		{
		}

		protected DictPoco(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

		/// <summary>
		/// 主键
		/// </summary>
		public String Key
		{
			get{ return this.GetString(P_Key);}
			set{ this.SetString(P_Key, value); }
		}

		/// <summary>
		/// 值
		/// </summary>
		public String Value
		{
			get{ return this.GetString(P_Value);}
			set{ this.SetString(P_Value, value); }
		}
	}
}