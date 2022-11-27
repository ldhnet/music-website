using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Repository;
using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Admin.Contracts; 

namespace Framework.Admin.Service
{
    public class AccountService : IAccountContract
    {
        private IAdminRepository _adminRepository;

        private IConsumerRepository _consumerRepository;

        public AccountService(IAdminRepository adminRepository, IConsumerRepository consumerRepository)
        {
            this._adminRepository = adminRepository;
            this._consumerRepository = consumerRepository;
        }
       /// <summary>
       /// 管理员登录
       /// </summary>
       /// <param name="dto"></param>
       /// <returns></returns>
        public TData<Biz_Admin> AdminLogin(AdminRequest dto)
        {
            TData<Biz_Admin> tData = new TData<Biz_Admin>(); 

            var info =  _adminRepository.GetFirstOrDefault(c => c.password == dto.password.Trim() && c.name == dto.username.Trim());

            if (info != null)
            {
                tData.data = info;
                tData.message = ("登录成功"); 
            }
            else
            {
                tData.tag = ResultTag.fail;
                tData.message = "登录失败";
          
            }
            return tData;
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public TData<Biz_Consumer> UserLogin(AdminRequest dto)
        {
            TData<Biz_Consumer> tData = new TData<Biz_Consumer>();
            var info = _consumerRepository.GetFirstOrDefault(c => c.password == dto.password.Trim() && c.username == dto.username.Trim());
            if (info != null)
            {
                tData.data = info;
                tData.message = ("登录成功"); 
            }
            else
            {
                tData.tag = ResultTag.fail;
                tData.message = ("登录失败"); 
            }
            return tData;
        }
    }
}
