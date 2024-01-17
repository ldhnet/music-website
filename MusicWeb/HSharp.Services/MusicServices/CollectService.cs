using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class CollectService : RepositoryFactory, ICollectContract
    {
        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TData> AddCollection(CollectRequest request)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = request.MapTo<Biz_Collect>();
            var result = await _Repository.Insert(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> CollectionOfUser(int userId)
        {
            TData<List<Biz_Collect>> obj = new TData<List<Biz_Collect>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Collect>(c => c.User_Id == userId);
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> DeleteCollect(int userId, int songId)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var result = await _Repository.Delete<Biz_Collect>(d => d.User_Id == userId && d.Song_Id == songId);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> ExistSongId(CollectRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Collect>();
            bool isExist = list.Any(d => d.User_Id == dto.User_Id && d.Song_Id == dto.Song_Id);
            string msg = isExist ? "已收藏" : "未收藏";
            obj.Data = isExist;
            obj.Description = msg;
            return obj;
        }
    }
}
