using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GTP.PortalDataService.WebSite.SingleOn;

namespace GTP.PortalDataService.WebSite.DataService.Ajax
{
    /// <summary>
    /// Common 的摘要说明
    /// </summary>
    public class Common : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request["type"] != null)
            {
                if (context.Request["type"].ToString() == "SingleOn")
                {
                    var usercode = context.Request["usercode"].ToString();
                    var ip = context.Request["ip"].ToString();
                    var port = context.Request["port"].ToString();
                    var id = context.Request["id"].ToString();
                    SingleOn.GetSSOStamp gs = new SingleOn.GetSSOStamp();
                    string str = gs.GetStamp(usercode);
                    string[] tempstr = str.Split('|');
                    HttpContext.Current.Response.Redirect("http://" + ip + ":" + port + "/Services/Identification/Server/login.ashx?sso=1&ssoProvider=WorkflowSSO&LoginFlag=custom&UserCode=" + usercode + "&LoginCredence=" + tempstr[0] + "&LoginTimestamp=" + tempstr[1] + "&service=/GTP/DataService/Common/RedirectUrl/RedirectUrl.aspx?id=" + id);
                }
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