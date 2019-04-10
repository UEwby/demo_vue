using GTP.PortalDataService.WorkFlow.Services;
using GTP.Runtime.Biz.Service;
using GTP.Runtime.Core.Loaders;
using GTP.Runtime.WebUI.Controllers;
using GTP.Runtime.WebUI.Direct;

namespace GTP.PortalDataService.Biz.WorkFlow.Controllers
{
    [Generated]
    [Version("1.0.0.0")]
    [Business("GTP.PortalDataService.WorkFlow.MessageController", MetadataRuntimeType.UIController)]
    class MessageController : PageUIController
    {
        [UIAction]
        /// <summary>
        /// 获取待阅任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
        public int GetToDoMessageCount(string userId)
        {
            IMessageService messageservice = ServiceFactory.GetService<IMessageService>();
            return messageservice.GetToDoMessageCount(userId);
        }
        [UIAction]
        /// <summary>
        /// 获取已阅任务个数(返回值：个数)
        /// </summary>
        /// <param name="userId">用户ID(""表示当前用户)</param>
        /// <returns></returns>
        public int GetFinishedMessageCount(string userId)
        {
            IMessageService messageservice = ServiceFactory.GetService<IMessageService>();
            return messageservice.GetFinishedMessageCount(userId);
        }
    }
}
