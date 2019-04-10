/****************************************************
 * 
 * 广联达软件股份有限责任公司版权所有.
 * 
 *****************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using GTP.PortalDataService.WorkFlow.Entities;
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
    /// 任务表服务
    /// </summary>
    partial class TaskService
    {

        private string GetTaskUserName(string code)
        {
            long id = Convert.ToInt64(code.Split('.')[0]);
            string gsql = "SELECT f_name as Name  FROM T_ORG_USER  WITH (NOLOCK) WHERE   F_USER_ID=" + id;
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            return ds.Tables[0].Rows[0]["Name"].ToString();
        }
        /// <summary>
        /// 获取待办待阅列表
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [Generated]
        protected override TASKTODOLISTPoco[] GetToDoList(Int32 size)
        {
            List<TASKTODOLISTPoco> getToDoTasklist = new List<TASKTODOLISTPoco>();
            string userId = GTP.Runtime.Common.Context.DataContextManager.SessionContext.UserID;
            string gsql = "SELECT TOP " + size + " f_id as Id,f_name as Title,F_EXECUTOR_ID as Name,F_CREATE_TIME as NewTime FROM T_WF_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID IN ('" + userId + ".S') AND task.F_STATUS='Running' ";
            gsql += "UNION ALL SELECT TOP " + size + " f_id as Id,f_name as Title,F_EXECUTOR_ID as Name,F_CREATE_TIME as NewTime FROM T_WFM_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID IN ('" + userId + ".S') AND task.F_STATUS='Running'  order by  NewTime  desc;";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    TASKTODOLISTPoco entity = new TASKTODOLISTPoco();
                    entity.Id = Convert.ToInt64(ds.Tables[0].Rows[i]["Id"]);
                    entity.Title = ds.Tables[0].Rows[i]["Title"] == null ? "" : ds.Tables[0].Rows[i]["Title"].ToString();
                    entity.Name = GetTaskUserName(ds.Tables[0].Rows[i]["Name"].ToString());
                    entity.NewTime = Convert.ToDateTime(ds.Tables[0].Rows[i]["NewTime"]).ToString("yyyy-mm-dd");
                    getToDoTasklist.Add(entity);
                }
            }
            TASKTODOLISTPoco[] ToDoTasklist = (from fz in getToDoTasklist
                                               select fz).OrderByDescending(p => p.NewTime).Take(size).ToArray();
            return ToDoTasklist;
        }
        /// <summary>
        /// 获取已办列表
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [Generated]
        protected override TASKTODOLISTPoco[] GetFinishedList(int size)
        {
            List<TASKTODOLISTPoco> getToDoTasklist = new List<TASKTODOLISTPoco>();
            string userId = GTP.Runtime.Common.Context.DataContextManager.SessionContext.UserID;
            string gsql = "SELECT TOP " + size + " f_id as Id,f_name as Title,F_EXECUTOR_ID as Name,F_CREATE_TIME as NewTime FROM T_WF_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID IN ('" + userId + ".S') AND task.F_STATUS='Finished' ";
            gsql += "UNION ALL SELECT TOP " + size + " f_id as Id,f_name as Title,F_EXECUTOR_ID as Name,F_CREATE_TIME as NewTime FROM T_WFM_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID IN ('" + userId + ".S') AND task.F_STATUS='Finished'  order by  NewTime  desc;";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    TASKTODOLISTPoco entity = new TASKTODOLISTPoco();
                    entity.Id = Convert.ToInt64(ds.Tables[0].Rows[i]["Id"]);
                    entity.Title = ds.Tables[0].Rows[i]["Title"] == null ? "" : ds.Tables[0].Rows[i]["Title"].ToString();
                    entity.Name = GetTaskUserName(ds.Tables[0].Rows[i]["Name"].ToString());
                    entity.NewTime = Convert.ToDateTime(ds.Tables[0].Rows[i]["NewTime"]).ToString("yyyy-mm-dd");
                    getToDoTasklist.Add(entity);
                }
            }
            TASKTODOLISTPoco[] ToDoTasklist = (from fz in getToDoTasklist
                                               select fz).OrderByDescending(p => p.NewTime).Take(size).ToArray();
            return ToDoTasklist;
        }
        protected override TASKTODOLISTPoco[] GetTaskList(int size)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取待办任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
        [Generated]
        protected override Int32 GetToDoTaskCount(String userId)
        {
            if (string.IsNullOrEmpty(userId))
                userId = GTP.Runtime.Common.Context.DataContextManager.SessionContext.UserID;
            var gsql = "SELECT COUNT(1) AS F_COUNT FROM T_WF_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID IN ('" + userId + ".S') AND task.F_STATUS='Running';";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds != null)
            {
                return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
                return 0;
        }
        /// <summary>
        /// 获取待办任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
        [Generated]
        protected override Int32 GetToDoTaskFilterCount(String userId, String filter)
        {
            if (string.IsNullOrEmpty(userId))
                userId = GTP.Runtime.Common.Context.DataContextManager.SessionContext.UserID;
            var gsql = "SELECT COUNT(1) AS F_COUNT FROM T_WF_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID IN ('" + userId + ".S') AND task.F_STATUS='Running' and F_MODULE_FCODE like '%" + filter + "%';";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds != null)
            {
                return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
                return 0;
        }
        /// <summary>
        /// 获取已办任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
        [Generated]
        protected override Int32 GetFinishedTaskCount(String userId)
        {
            if (string.IsNullOrEmpty(userId))
                userId = GTP.Runtime.Common.Context.DataContextManager.SessionContext.UserID;
            var gsql = "select count(*) as f_count from (SELECT distinct f_flow_id FROM T_WF_TASK task WITH (NOLOCK) WHERE task.F_EXECUTOR_ID IN ('" + userId + ".S') AND task.F_STATUS ='Finished') a;";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds != null)
            {
                return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
                return 0;
        }
        /// <summary>
        /// 获取各模块使用个数
        /// </summary>
        /// <returns></returns>
        [Generated]
        protected override DictPoco[] GetModuleUseCount()
        {
            var gsql = "SELECT f_module_fname as name_, COUNT(f_id) as count_ from t_wf_task with(nolock) GROUP BY f_module_fcode,f_module_fname order by count(f_id) desc";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds != null)
            {
                List<DictPoco> dictList = new List<DictPoco>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DictPoco dict = new DictPoco();
                    dict.Key = row["name_"].ToString();
                    dict.Value = row["count_"].ToString();
                    dictList.Add(dict);
                }
                return dictList.ToArray();
            }
            else
                return null;
        }
        /// <summary>
        /// 任务办结率统计
        /// </summary>
        /// <returns></returns>
        [Generated]
        protected override DictPoco[] GetTaskHandleCount()
        {
            var gsql = "select  f_status as status_,count(f_status) as count_ from t_wf_task with(nolock) where f_kind='Flow' and f_status in ('Running','Finished') GROUP BY f_status order by f_status desc";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds != null)
            {
                List<DictPoco> dictList = new List<DictPoco>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DictPoco dict = new DictPoco();
                    dict.Key = row["status_"].ToString();
                    dict.Value = row["count_"].ToString();
                    dictList.Add(dict);
                }
                return dictList.ToArray();
            }
            else
                return null;
        }
        /// <summary>
        /// 任务状态统计
        /// </summary>
        /// <returns></returns>
        [Generated]
        protected override DictPoco[] GetTaskStatusCount()
        {
            var gsql = "select f_status as status_,count(f_status) as count_ from t_wf_task with(nolock) where f_kind='Flow' and f_status in ('Running','Finished','Deleted','Aborted') GROUP BY f_status order by f_status desc";
            DataSet ds = LiteDB.ExecuteDataSet(gsql);
            if (ds != null)
            {
                List<DictPoco> dictList = new List<DictPoco>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DictPoco dict = new DictPoco();
                    dict.Key = row["status_"].ToString();
                    dict.Value = row["count_"].ToString();
                    dictList.Add(dict);
                }
                return dictList.ToArray();
            }
            else
                return null;
        }

    }
}