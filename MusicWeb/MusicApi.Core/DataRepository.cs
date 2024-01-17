using System.Text; 
using HSharp.Data.Repository;
using HSharp.Enum.OrganizationManage;
using HSharp.Util;
using HSharp.Util.Extension;

namespace MusicApi.Core
{
    public class DataRepository : RepositoryFactory
    {
        public async Task<OperatorInfo> GetUserByToken(string token)
        {
            if (!SecurityHelper.IsSafeSqlParam(token))
            {
                return null;
            }
            token = token.ParseToString().Trim();

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
            var operatorInfo = await _Repository.FindObject<OperatorInfo>(strSql.ToString());
            if (operatorInfo != null)
            {
                #region 角色
                strSql.Clear();
                strSql.Append(@"SELECT  a.BelongId as RoleId
                                FROM    SysUserBelong a
                                WHERE   a.UserId = " + operatorInfo.UserId + " AND ");
                strSql.Append("         a.BelongType = " + UserBelongTypeEnum.Role.ParseToInt());
                IEnumerable<RoleInfo> roleList = await _Repository.FindList<RoleInfo>(strSql.ToString());
                operatorInfo.RoleIds = string.Join(",", roleList.Select(p => p.RoleId).ToArray());
                #endregion

                #region 部门名称
                strSql.Clear();
                strSql.Append(@"SELECT  a.DepartmentName
                                FROM    SysDepartment a
                                WHERE   a.Id = " + operatorInfo.DepartmentId);
                SysDepartment department = await _Repository.FindObject<SysDepartment>(strSql.ToString());
                operatorInfo.DepartmentName = department.DepartmentName;
                #endregion
            }
            return operatorInfo;
        }

    }
}
