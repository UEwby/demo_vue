/****************************************************
 * 
 * 广联达软件股份有限责任公司版权所有.
 * 
 *****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using GTP.Runtime.Biz.Event.Engine;
using GTP.Runtime.Biz.Query;
using GTP.Runtime.Biz.Service;
using GTP.Runtime.Core.Loaders;
using GTP.Runtime.DataObject;
using GTP.Runtime.Metadata.Common;
using GTP.Runtime.Metadata.Model.Event;

namespace GTP.PortalDataService.WorkFlow.Services
{
	#region 接口 IMessageService 

	/// <summary>
	/// 待阅服务
	/// </summary>
    [Generated]
    [Version("1.0.0.0")]
    [Business("GTP.PortalDataService.WorkFlow.Message", MetadataRuntimeType.Interface)]
    public interface IMessageService : IBusinessService
    {

        /// <summary>
        /// 获取待阅任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.NotSupported)]
		Int32 GetToDoMessageCount(String userId);

        /// <summary>
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.NotSupported)]
		Int32 GetFinishedMessageCount(String userId);
    }

	#endregion 接口结束

	#region  抽象类 AbstractMessageService

	/// <summary>
	/// 待阅服务
	/// </summary>
    [Generated]
    [Version("1.0.0.0")]
	public abstract class AbstractMessageService : GTPService, IMessageService
    {
        protected const string METADATA_NAME = "GTP.PortalDataService.WorkFlow.Message";

	protected override string GetMetadataName()
        {
            return METADATA_NAME;
        }

		#region 实现接口 IMessageService 成员

        /// <summary>
        /// 获取待阅任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		Int32 IMessageService.GetToDoMessageCount(String userId)
		{
            Int32 returnTempObject = this.GetToDoMessageCount(userId);
            return returnTempObject;
		}

        /// <summary>
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		Int32 IMessageService.GetFinishedMessageCount(String userId)
		{
            Int32 returnTempObject = this.GetFinishedMessageCount(userId);
            return returnTempObject;
		}

		#endregion 实现接口结束

		#region 抽象方法 AbstractClassName 成员

        /// <summary>
        /// 获取待阅任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		protected abstract Int32 GetToDoMessageCount(String userId);

        /// <summary>
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		protected abstract Int32 GetFinishedMessageCount(String userId);
    
		#endregion 抽象方法结束
	}

	#endregion 抽象类结束

	/// <summary>
	/// 待阅服务
	/// </summary>
	[Business("GTP.PortalDataService.WorkFlow.Message", MetadataRuntimeType.Service)]
	public partial class MessageService : AbstractMessageService
    {
    }
}
