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
	#region 接口 ITaskService 

	/// <summary>
	/// 任务表服务
	/// </summary>
    [Generated]
    [Version("1.0.0.0")]
    [Business("GTP.PortalDataService.WorkFlow.Task", MetadataRuntimeType.Interface)]
    public interface ITaskService : IBusinessService
    {

        /// <summary>
        /// 获取待办任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.NotSupported)]
		Int32 GetToDoTaskCount(String userId);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.NotSupported)]
		Int32 GetToDoTaskFilterCount(String userId, String filter);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.Required)]
		Int32 GetFinishedTaskCount(String userId);

        /// <summary>
        /// 获取各模块使用个数
        /// </summary>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.NotSupported)]
		GTP.PortalDataService.WorkFlow.Entities.DictPoco[] GetModuleUseCount();

        /// <summary>
        /// 任务办结率统计
        /// </summary>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.NotSupported)]
		GTP.PortalDataService.WorkFlow.Entities.DictPoco[] GetTaskHandleCount();

        /// <summary>
        /// 任务状态统计
        /// </summary>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.NotSupported)]
		GTP.PortalDataService.WorkFlow.Entities.DictPoco[] GetTaskStatusCount();

        /// <summary>
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.Required)]
		GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] GetToDoList(Int32 size);

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.Required)]
		GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] GetFinishedList(Int32 index);

        /// <summary>
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
		[Generated]
		[Transaction(TransactionType.Required)]
		GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] GetTaskList(Int32 size);
    }

	#endregion 接口结束

	#region  抽象类 AbstractTaskService

	/// <summary>
	/// 任务表服务
	/// </summary>
    [Generated]
    [Version("1.0.0.0")]
	public abstract class AbstractTaskService : GTPService, ITaskService
    {
        protected const string METADATA_NAME = "GTP.PortalDataService.WorkFlow.Task";

	protected override string GetMetadataName()
        {
            return METADATA_NAME;
        }

		#region 实现接口 ITaskService 成员

        /// <summary>
        /// 获取待办任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		Int32 ITaskService.GetToDoTaskCount(String userId)
		{
            Int32 returnTempObject = this.GetToDoTaskCount(userId);
            return returnTempObject;
		}

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
		[Generated]
		Int32 ITaskService.GetToDoTaskFilterCount(String userId, String filter)
		{
            Int32 returnTempObject = this.GetToDoTaskFilterCount(userId,filter);
            return returnTempObject;
		}

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
		[Generated]
		Int32 ITaskService.GetFinishedTaskCount(String userId)
		{
            Int32 returnTempObject = this.GetFinishedTaskCount(userId);
            return returnTempObject;
		}

        /// <summary>
        /// 获取各模块使用个数
        /// </summary>
        /// <returns></returns>
		[Generated]
		GTP.PortalDataService.WorkFlow.Entities.DictPoco[] ITaskService.GetModuleUseCount()
		{
            GTP.PortalDataService.WorkFlow.Entities.DictPoco[] returnTempObject = this.GetModuleUseCount();
            return returnTempObject;
		}

        /// <summary>
        /// 任务办结率统计
        /// </summary>
        /// <returns></returns>
		[Generated]
		GTP.PortalDataService.WorkFlow.Entities.DictPoco[] ITaskService.GetTaskHandleCount()
		{
            GTP.PortalDataService.WorkFlow.Entities.DictPoco[] returnTempObject = this.GetTaskHandleCount();
            return returnTempObject;
		}

        /// <summary>
        /// 任务状态统计
        /// </summary>
        /// <returns></returns>
		[Generated]
		GTP.PortalDataService.WorkFlow.Entities.DictPoco[] ITaskService.GetTaskStatusCount()
		{
            GTP.PortalDataService.WorkFlow.Entities.DictPoco[] returnTempObject = this.GetTaskStatusCount();
            return returnTempObject;
		}

        /// <summary>
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
		[Generated]
		GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] ITaskService.GetToDoList(Int32 size)
		{
            GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] returnTempObject = this.GetToDoList(size);
            return returnTempObject;
		}

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
		[Generated]
		GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] ITaskService.GetFinishedList(Int32 index)
		{
            GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] returnTempObject = this.GetFinishedList(index);
            return returnTempObject;
		}

        /// <summary>
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
		[Generated]
		GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] ITaskService.GetTaskList(Int32 size)
		{
            GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] returnTempObject = this.GetTaskList(size);
            return returnTempObject;
		}

		#endregion 实现接口结束

		#region 抽象方法 AbstractClassName 成员

        /// <summary>
        /// 获取待办任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
		[Generated]
		protected abstract Int32 GetToDoTaskCount(String userId);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
		[Generated]
		protected abstract Int32 GetToDoTaskFilterCount(String userId, String filter);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
		[Generated]
		protected abstract Int32 GetFinishedTaskCount(String userId);

        /// <summary>
        /// 获取各模块使用个数
        /// </summary>
        /// <returns></returns>
		[Generated]
		protected abstract GTP.PortalDataService.WorkFlow.Entities.DictPoco[] GetModuleUseCount();

        /// <summary>
        /// 任务办结率统计
        /// </summary>
        /// <returns></returns>
		[Generated]
		protected abstract GTP.PortalDataService.WorkFlow.Entities.DictPoco[] GetTaskHandleCount();

        /// <summary>
        /// 任务状态统计
        /// </summary>
        /// <returns></returns>
		[Generated]
		protected abstract GTP.PortalDataService.WorkFlow.Entities.DictPoco[] GetTaskStatusCount();

        /// <summary>
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
		[Generated]
		protected abstract GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] GetToDoList(Int32 size);

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
		[Generated]
		protected abstract GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] GetFinishedList(Int32 index);

        /// <summary>
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
		[Generated]
		protected abstract GTP.PortalDataService.WorkFlow.Entities.TASKTODOLISTPoco[] GetTaskList(Int32 size);
    
		#endregion 抽象方法结束
	}

	#endregion 抽象类结束

	/// <summary>
	/// 任务表服务
	/// </summary>
	[Business("GTP.PortalDataService.WorkFlow.Task", MetadataRuntimeType.Service)]
	public partial class TaskService : AbstractTaskService
    {
    }
}
