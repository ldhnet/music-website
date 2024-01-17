using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class SingerService : RepositoryFactory, ISingerContract
    {

        public async Task<TData> AddSinger(SingerRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = dto.MapTo<Biz_Singer>();
            var result = await _Repository.Insert(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> AllSinger()
        {
            TData<List<Biz_Singer>> obj = new TData<List<Biz_Singer>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Singer>();
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> DeleteSinger(int id)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var result = await _Repository.Delete<Biz_Singer>(d => d.Id == id);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> SingerOfName(string name)
        {
            TData<List<Biz_Singer>> obj = new TData<List<Biz_Singer>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Singer>(c => c.Name == name.Trim());
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> SingerOfSex(int sex)
        {
            TData<List<Biz_Singer>> obj = new TData<List<Biz_Singer>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Singer>(c => c.Sex == sex);
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> UpdateSingerMsg(SingerRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = await _Repository.FindEntity<Biz_Singer>(c => c.Id == dto.Id);
            entity.Name = dto.Name;
            entity.Sex = dto.Sex;
            entity.Introduction = dto.Introduction;
            entity.Location = dto.Location;
            entity.Birth = dto.Birth;
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> UpdateSingerPic(int singerId, string singerPic)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = await _Repository.FindEntity<Biz_Singer>(c => c.Id == singerId);
            entity.Pic = singerPic;
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }
    }
}
