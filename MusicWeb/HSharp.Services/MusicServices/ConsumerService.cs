using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class ConsumerService : RepositoryFactory, IConsumerContract
    {
        public async Task<TData> UserLogin(LoginRequest request)
        {
            TData<Biz_Consumer> obj = new TData<Biz_Consumer>();
            obj.Tag = 1; 
            var result = await _Repository.FindEntity<Biz_Consumer>(c=>c.UserName == request.UserName.Trim() && c.Password == request.Password.Trim());
            obj.Data = result;
            obj.Description = result.Id > 0 ? "登录成功" : "登录失败";
            return obj;
        }

        public async Task<TData> AddUser(ConsumerRequest registryRequest)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = registryRequest.MapTo<Biz_Consumer>();
            var result = await _Repository.Insert(entity);
            obj.Data = result > 0;
            obj.Description = result > 0 ? "注册成功" : "注册失败";
            return obj;
        }

        public async Task<TData> AllUser()
        {
            TData<List<Biz_Consumer>> obj = new TData<List<Biz_Consumer>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Consumer>();
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> DeleteUser(int id)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var result = await _Repository.Delete<Biz_Consumer>(d => d.Id == id);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> ExistUser(string username)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;

            var list = await _Repository.FindList<Biz_Consumer>(d => d.UserName == username);
            var result = list.Any();
            obj.Data = result;
            return obj;
        }

        public async Task<TData> LoginStatus(ConsumerRequest dto)
        {
            TData<bool> obj = new TData<bool>();

            if (await VerityPasswd(dto.UserName.Trim(), dto.Password.Trim()))
            {
                obj.Tag = 1;
                var data = _Repository.FindEntity<Biz_Consumer>(c => c.UserName == dto.UserName.Trim() && c.Password == dto.Password.Trim()); ;
                obj.Description = "登录成功！";
                return obj;
            }
            else
            {
                obj.Tag = 0;
                obj.Description = "登录失败";
                return obj;
            }
        }

        public async Task<TData> UpdatePassword(ConsumerRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;

            var entity = await _Repository.FindEntity<Biz_Consumer>(c => c.Id == dto.Id);
            entity.Password = dto.Password.Trim();
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> UpdateUserAvator(string avatorFileUrl, int id)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = await _Repository.FindEntity<Biz_Consumer>(c => c.Id == id);
            entity.Avator = avatorFileUrl;

            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> UpdateUserMsg(ConsumerRequest dto)
        {

            var entity = await _Repository.FindEntity<Biz_Consumer>(c => c.Id == dto.Id);
            entity.UserName = dto.UserName;
            entity.Sex = dto.Sex;
            entity.Birth = dto.Birth;
            entity.Email = dto.Email;
            entity.Phone_Num = dto.Phone_Num;
            entity.Introduction = dto.Introduction;
            entity.Location = dto.Location;
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> UserOfId(int id)
        {
            TData<List<Biz_Consumer>> obj = new TData<List<Biz_Consumer>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Consumer>(c => c.Id == id);
            obj.Data = list.ToList();
            return obj;
        }

        private async Task<bool> VerityPasswd(string username, string password)
        {
            var list = await _Repository.FindList<Biz_Consumer>(c => c.UserName == username.Trim() && c.Password == password);
            return list.Any();
        }
    }
}
