using Framework.Utility.ViewModels; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Framework.Repository
{
    public class DataRepository 
    {
        public async Task<OperatorInfo> GetUserByToken(string token)
        { 
            token = token.Trim();

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT  a.Id as UserId,
                                    a.UserStatus,
                                    a.IsOnline,
                                    a.UserName,
                                    a.RealName,
                                    a.Portrait,
                                    a.DepartmentId,
                                    a.WebToken,
                                    a.ApiToken,
                                    a.IsSystem
                            FROM    SysUser a
                            WHERE   WebToken = '" + token + "' or ApiToken = '" + token + "'  ");
            //var operatorInfo = await Repository().FindObject<OperatorInfo>(strSql.ToString());
            await Task.Delay(100);
            return new OperatorInfo();
        }

    }
}
