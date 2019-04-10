using System;
using System.Collections.Generic;
using System.Data;
using GTP.PortalDataService.WorkFlow.Entities;
using GTP.PortalDataService.WorkFlow.Services;
using GTP.Runtime.Biz.Service;
using GTP.Runtime.Core.Loaders;
using GTP.Runtime.DataObject;
using GTP.Runtime.Metadata.Model.Entity;
using GTP.Runtime.Metadata.Model.Query;
using GTP.Runtime.NamedSql;
using GTP.Runtime.NamedSql.Ibatis;
using GTP.Runtime.WebUI.Controllers;
using GTP.Runtime.WebUI.Direct;
using GTP.Runtime.WebUI.Query;
using GTP.Services.GSqlWraper;
using GTP.Workflow.Biz.TaskMessage.Controllers.Result;

namespace GTP.PortalDataService.WorkFlow.Controllers
{
    [Generated]
    [Version("1.0.0.0")]
    [Business("GTP.PortalDataService.WorkFlow.TaskController", MetadataRuntimeType.UIController)]
    class TaskController : PageUIController
    {
        //private static Dictionary<string, string> DataDesc = InitDataDesc();
        private static string sRunningStatus = "'Standby','Running','Waiting','Waited','Locked'";
        [UIAction]
        public string getUserID()
        {
            string userId = GTP.Runtime.Common.Context.DataContextManager.SessionContext.UserID;
            return userId;
        }

        # region 待办待阅 已办已阅
        /// <summary>
        /// 获取待办待阅List
        /// </summary>
        /// <returns></returns>
        [UIAction]
        public TASKTODOLISTPoco[] GetToDoList(Int32 size)
        {
            ITaskService taskservice = ServiceFactory.GetService<ITaskService>();
            return taskservice.GetToDoList(size);

        }
        /// <summary>
        /// 获取已办已阅List
        /// </summary>
        /// <returns></returns>
        [UIAction]
        public TASKTODOLISTPoco[] GetFinishedList(Int32 size)
        {
            ITaskService taskservice = ServiceFactory.GetService<ITaskService>();
            return taskservice.GetFinishedList(size);

        }
        #endregion
        #region 通知公告
        /// <summary>
        /// 获取信息发布的信息
        /// </summary>
        /// <param name="columnName">栏目名称</param>
        /// <returns></returns>
        [UIAction]
        public IList<XXFBPoco> GetXXFB(String columnCode)              //String columnCode
        {
            return Utils.XMHNamedSqlUtils.SelectXXFBtInfo(columnCode);
        }
        #endregion
    }
}
