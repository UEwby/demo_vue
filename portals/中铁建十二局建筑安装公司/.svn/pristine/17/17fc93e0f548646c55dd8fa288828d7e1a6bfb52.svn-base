/****************************************************
 * 
 * 广联达软件股份有限责任公司版权所有.
 * 
 *****************************************************/
using System;
using System.Collections.Generic;
using GTP.Runtime.Core.Loaders;
using GTP.Runtime.DataObject;
using GTP.Runtime.NamedSql;
using GTP.Runtime.NamedSql.Ibatis;
using GTP.Runtime.Core.Transactions;

namespace GTP.PortalDataService.WorkFlow.Utils
{
	[Generated]
    [Version("1.0.0.0")]
    internal static class XMHNamedSqlUtils
    {
					
        /// <summary>
        /// 查询信息发布的信息
        /// </summary>
        /// <param name="columnCode"></param>
        /// <returns></returns>
		[Generated]
		internal static System.Collections.Generic.IList<GTP.PortalDataService.WorkFlow.Entities.XXFBPoco> SelectXXFBtInfo(String columnCode , string dsName = "default")
		{
			ISqlStatementExecutor executor = NamedSqlUtils.GetExecutor(dsName, "GTP.PortalDataService.WorkFlow.XMHNamedSql.SelectXXFBtInfo");
			IDictionary<string, object> dict = new Dictionary<string, object>();
			#region-----构造Dictionary-----
            dict.Add("columnCode", columnCode);
            #endregion
			return executor.QueryForList<GTP.PortalDataService.WorkFlow.Entities.XXFBPoco>(dict);
		}
	    }
}