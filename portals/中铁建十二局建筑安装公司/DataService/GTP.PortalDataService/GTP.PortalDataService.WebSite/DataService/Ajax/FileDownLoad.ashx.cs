using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GTP.Services.FileService.Core.Client;

namespace GTP.PortaDataService.WebSite.DataService.Ajax
{
    /// <summary>
    /// FileDownLoad 的摘要说明
    /// </summary>
    public class FileDownLoad : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = System.Web.HttpContext.Current.Request;
            var id = request.QueryString["id"].ToString();
            var viewguid = request.QueryString["viewguid"].ToString();
            IAdvanceFileServiceClient client = (IAdvanceFileServiceClient)FileServiceClientFactory.CreateClient();
            DownloadFileParameterInfo param = new DownloadFileParameterInfo
            {
                Id = Int32.Parse(id),
                ViewGuid = viewguid,
                EditGuid = "",
                DeleteAfterDownload = false
            };
            string url = client.GetDownloadUrl(param);
            HttpContext.Current.Response.Redirect(url);
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