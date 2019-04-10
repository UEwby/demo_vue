/****************************************************
 * 
 * 广联达软件股份有限责任公司版权所有.
 * 
 *****************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using GTP.Runtime.Biz.Event.Engine;
using GTP.Runtime.Biz.Query;
using GTP.Runtime.Biz.Service;
using GTP.Runtime.Core.Loaders;
using GTP.Runtime.DataObject;
using GTP.Runtime.Metadata.Common;
using GTP.Runtime.Metadata.Model.Event;
using GTP.Services.GSqlWraper;

namespace GTP.PortalDataService.WorkFlow.Services
{
    /// <summary>
    /// 待阅服务
    /// </summary>
    partial class MessageService
    {

        /// <summary>
        /// 获取待阅任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
        [Generated]
        protected override Int32 GetToDoMessageCount(String userId)
        {
            if (string.IsNullOrEmpty(userId))
                userId = GTP.Runtime.Common.Context.DataContextManager.SessionContext.UserID;
            var gsql = "SELECT COUNT(1) AS F_COUNT FROM T_WFM_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID='" + userId + ".S' AND task.F_STATUS='Running';";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds != null)
            {
                return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
                return 0;
        }

        /// <summary>
        /// 获取已阅任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
        [Generated]
        protected override Int32 GetFinishedMessageCount(String userId)
        {
            if (string.IsNullOrEmpty(userId))
                userId = GTP.Runtime.Common.Context.DataContextManager.SessionContext.UserID;
            var gsql = "SELECT COUNT(1) AS F_COUNT FROM T_WFM_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID='" + userId + ".S' AND task.F_STATUS='Finished';";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds != null)
            {
                return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
                return 0;
        }
    }

}