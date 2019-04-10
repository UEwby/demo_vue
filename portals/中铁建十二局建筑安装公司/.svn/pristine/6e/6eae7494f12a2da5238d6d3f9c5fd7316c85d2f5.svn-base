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
	/// 信息发布
	/// </summary>
	[Serializable]
	[Generated]
    [Version("1.0.0.0")]
    [Business("GTP.PortalDataService.WorkFlow.XXFBPoco", MetadataRuntimeType.Poco)]
	public class XXFBPoco : SimpleEntity
	{
		public const string P_id = "id";
		public const string P_title = "title";
		public const string P_remark = "remark";
		public const string P_createTime = "createTime";
		public const string P_creatorName = "creatorName";
		public const string P_contentHtml = "contentHtml";
		public const string P_contentImage = "contentImage";
		public const string P_creatorId = "creatorId";
		public const string METADATA_NAME = "GTP.PortalDataService.WorkFlow.XXFBPoco";
		
		public XXFBPoco(string typeName)
			: base(typeName)
		{
		}

		public XXFBPoco()
			: base(METADATA_NAME)
		{
		}

		protected XXFBPoco(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

		/// <summary>
		/// 主键
		/// </summary>
		public Int64 id
		{
			get{ return this.GetLong(P_id);}
			set{ this.SetLong(P_id, value); }
		}

		/// <summary>
		/// 标题
		/// </summary>
		public String title
		{
			get{ return this.GetString(P_title);}
			set{ this.SetString(P_title, value); }
		}

		/// <summary>
		/// 内容
		/// </summary>
		public String remark
		{
			get{ return this.GetString(P_remark);}
			set{ this.SetString(P_remark, value); }
		}

		/// <summary>
		/// 发布时间
		/// </summary>
		public String createTime
		{
			get{ return this.GetString(P_createTime);}
			set{ this.SetString(P_createTime, value); }
		}

		/// <summary>
		/// 发布人
		/// </summary>
		public String creatorName
		{
			get{ return this.GetString(P_creatorName);}
			set{ this.SetString(P_creatorName, value); }
		}

		/// <summary>
		/// 内容html
		/// </summary>
		public String contentHtml
		{
			get{ return this.GetString(P_contentHtml);}
			set{ this.SetString(P_contentHtml, value); }
		}

		/// <summary>
		/// 内容图片
		/// </summary>
		public String contentImage
		{
			get{ return this.GetString(P_contentImage);}
			set{ this.SetString(P_contentImage, value); }
		}

		/// <summary>
		/// 创建人ID
		/// </summary>
		public Int64 creatorId
		{
			get{ return this.GetLong(P_creatorId);}
			set{ this.SetLong(P_creatorId, value); }
		}
	}
}