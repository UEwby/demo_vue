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
	/// TaskToDoList
	/// </summary>
	[Serializable]
	[Generated]
    [Version("1.0.0.0")]
    [Business("GTP.PortalDataService.WorkFlow.TASKTODOLISTPoco", MetadataRuntimeType.Poco)]
	public class TASKTODOLISTPoco : SimpleEntity
	{
		public const string P_Id = "Id";
		public const string P_Title = "Title";
		public const string P_Name = "Name";
		public const string P_NewTime = "NewTime";
		public const string METADATA_NAME = "GTP.PortalDataService.WorkFlow.TASKTODOLISTPoco";
		
		public TASKTODOLISTPoco(string typeName)
			: base(typeName)
		{
		}

		public TASKTODOLISTPoco()
			: base(METADATA_NAME)
		{
		}

		protected TASKTODOLISTPoco(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

		/// <summary>
		/// </summary>
		public Int64 Id
		{
			get{ return this.GetLong(P_Id);}
			set{ this.SetLong(P_Id, value); }
		}

		/// <summary>
		/// </summary>
		public String Title
		{
			get{ return this.GetString(P_Title);}
			set{ this.SetString(P_Title, value); }
		}

		/// <summary>
		/// </summary>
		public String Name
		{
			get{ return this.GetString(P_Name);}
			set{ this.SetString(P_Name, value); }
		}

		/// <summary>
		/// </summary>
		public String NewTime
		{
			get{ return this.GetString(P_NewTime);}
			set{ this.SetString(P_NewTime, value); }
		}
	}
}