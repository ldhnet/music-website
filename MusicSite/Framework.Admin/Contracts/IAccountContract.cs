using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Admin.Contracts
{
    public interface IAccountContract
    {
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        TData<Biz_Admin> AdminLogin(AdminRequest dto);
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        TData<Biz_Consumer> UserLogin(AdminRequest dto);
    }
}
