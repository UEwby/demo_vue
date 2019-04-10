﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using GTP.Services.GSqlWraper;

namespace GTP.PortaDataService.WebSite.DataService.Ajax
{
    /// <summary>
    /// PCenterAjax 的摘要说明
    /// </summary>
    public class PCenterAjax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                //本页禁止缓存
                context.Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
                context.Response.Cache.SetNoStore();

                //TODO: 应加入网站身份验证，未登录用户禁止访问本页
                context.Response.ContentType = "text/plain";
                if (context.Request["type"] != null)
                {
                    if (context.Request["type"].ToString() == "GetModuleData")
                    {
                        var gsql = "select f_id as id_,f_name as name_,F_PATTERN as pattern_,F_SETTING AS setting_ from t_pcenter_module with(nolock) where  concat(',',(select f_modules from t_pcenter_role where f_type=0 and f_type_id='1009'),',') like concat('%,',TO_CHAR(f_id),',%')";
                        DataSet ds = LiteDB.ExecuteDataSet(gsql);
                        if (ds != null)
                        {
                            var json = "[";
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                json += "{";
                                json += "\"ModuleID\":" + row["id_"].ToString() + ",";
                                json += "\"ModuleName\":\"" + row["name_"].ToString() + "\",";
                                if (row["pattern_"].ToString() == "2")
                                    json += "\"URL\":\"/PCenter/index.html?Id=" + row["id_"].ToString() + "\"";
                                else if (row["pattern_"].ToString() == "3")
                                    json += "\"URL\":\"/PCenter/index.html?Id=" + row["id_"].ToString() + "\"";
                                else
                                    json += "\"URL\":\"" + row["setting_"].ToString() + "\"";
                                json += "},";
                            }
                            if (json.Length > 1)
                                json = json.Substring(0, json.Length - 1);
                            json += "]";
                            context.Response.Write(json);
                        }
                        else
                            context.Response.Write("[]");
                    }
                }
            }
            catch (Exception ex)
            {
                context.Response.Write("[]");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}