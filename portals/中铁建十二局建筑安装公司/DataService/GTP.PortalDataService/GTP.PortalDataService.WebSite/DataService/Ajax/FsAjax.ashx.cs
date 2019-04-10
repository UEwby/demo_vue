using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GTP.Services.FileService;
using GTP.Services.FileService.Core.Client;
using GTP.Services.FileService.Core.DAL;

namespace GTP.PortalDataService.WebSite.DataService.Ajax
{
    /// <summary>
    /// type=add 上传附件
    /// </summary>
    public class FsAjax : IHttpHandler
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
                    if (context.Request["type"].ToString() == "add")
                    {
                        var fileClient = (IAdvanceFileServiceClient)FileServiceClientFactory.CreateClient();    //创建文件服务对象
                        HttpFileCollection files = context.Request.Files;
                        if (files != null)
                        {
                            var message = "";
                            var bol = false;
                            for (var i = 0; i < files.Count; ++i)
                            {
                                HttpPostedFile fileitem = files[i];
                                if (fileitem != null)
                                {
                                    var result = fileClient.UploadFile(new UploadFileParameterInfo                      //上传文件
                                    {
                                        AppNamespace = context.Request.Form["appNameSpace"] ?? ConstDefine.GTP_FS_DEFAULT_APP_NAMESPACE,
                                        FileDesc = "",
                                        FileExtentAttribute = "",
                                        Stream = fileitem.InputStream,
                                        FileName = fileitem.FileName,
                                        FieldName = ""
                                    });
                                    if (result.IsSuccess)
                                    {
                                        ServerFileAttachmentInfo fileRelation = new ServerFileAttachmentInfo();
                                        fileRelation.FileID = result.Data.Id;
                                        fileRelation.TableName = context.Request.Form["tableName"];
                                        fileRelation.TableKey = context.Request.Form["tableKey"];
                                        fileRelation.AppNamespace = context.Request.Form["appNamespace"] ?? ConstDefine.GTP_FS_DEFAULT_APP_NAMESPACE;
                                        fileRelation.FileSize = result.Data.FileSize;
                                        fileRelation.FileDesc = result.Data.FileDesc;
                                        fileRelation.FileName = result.Data.OriginalName;
                                        fileRelation.ViewGUID = result.Data.ViewGuid;
                                        fileRelation.EditGUID = result.Data.EditGuid;
                                        if (GTP.Services.Identification.SessionContext.Current != null)
                                            fileRelation.UserID = long.Parse(GTP.Services.Identification.SessionContext.Current.UserID);
                                        else
                                            fileRelation.UserID = -1;
                                        int ret = ServerFileAttachment.InsertFileAttachment(fileRelation, true);
                                        if (ret == 0)
                                            message += fileRelation.FileID + ",";
                                        else
                                        {
                                            bol = true;
                                        }
                                    }
                                    else
                                    {
                                        bol = true;
                                        message += result.ErrorMessage + ",";
                                    }
                                }
                            }
                            if (bol)
                                context.Response.Write("{success:false,msg:" + message + "}");
                            else
                                context.Response.Write("{success:true,msg:'成功',fileID:" + message + "}");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message + "\r\n" + ex.StackTrace;
                msg = msg.Replace("'", "\\'").Replace("\"", "\\\"");
                msg = msg.Replace("\r", "\\r").Replace("\n", "\\n");
                context.Response.Write("{success:false,msg:'" + msg + "'}");
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