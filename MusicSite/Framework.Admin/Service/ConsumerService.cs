using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Repository;
using Framework.Utility.Helper;
using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Admin.Contracts; 

namespace Framework.Admin.Service
{
    public class ConsumerService : IConsumerContract
    {
        private IConsumerRepository _consumerRepository;

        public ConsumerService(IConsumerRepository consumerRepository)
        {
            _consumerRepository = consumerRepository;
        }

        public TData AddUser(ConsumerRequest registryRequest)
        {
            var entity = registryRequest.MapTo<Biz_Consumer>();
            var result = _consumerRepository.Insert(entity);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData AllUser()
        {
            var list =  _consumerRepository.EntitiesAsNoTracking.ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData DeleteUser(int id)
        {
            var result = _consumerRepository.Delete(d => d.id == id);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public bool ExistUser(string username)
        { 
            return _consumerRepository.CheckExists(d => d.username == username.Trim()); 
        }

        public TData LoginStatus(ConsumerRequest dto)
        {  
            if (VerityPasswd(dto.username.Trim(), dto.password.Trim()))
            {
                var data = _consumerRepository.GetFirstOrDefault(c => c.username == dto.username.Trim() && c.password == dto.password.Trim()); ;

                return new TData(ResultTag.success, "登录成功", data);
            }
            else { 
                return new TData(ResultTag.success, "登录失败");
            } 
        }

        public TData UpdatePassword(ConsumerRequest dto)
        {
            var entity = _consumerRepository.Entities.First(c=>c.id == dto.id);
            entity.password=dto.password.Trim();
            return _consumerRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData UpdateUserAvator(string avatorFileUrl, int id)
        {
            var entity = _consumerRepository.Entities.First(c => c.id == id);
            entity.avator = avatorFileUrl;
            return _consumerRepository.Update(entity) > 0 ? new TData(ResultTag.success, "图片上传成功", avatorFileUrl) : new TData(ResultTag.fail);
        }

        public TData UpdateUserMsg(ConsumerRequest dto)
        {
            //var entity = updateRequest.MapTo<Biz_Consumer>();
            var entity = _consumerRepository.GetByKey(dto.id);
            entity.username = dto.username;
            entity.sex = dto.sex;
            entity.birth = dto.birth;
            entity.email = dto.email;
            entity.phone_num = dto.phone_num;  
            entity.introduction = dto.introduction;  
            entity.location = dto.location;             
            return _consumerRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData UserOfId(int id)
        {
            var list = _consumerRepository.QueryAsNoTracking(c=>c.id == id).ToList(); 
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public bool VerityPasswd(string username, string password)
        {
            return _consumerRepository.CheckExists(c => c.username == username.Trim() && c.password == password);
        }
    }
}
