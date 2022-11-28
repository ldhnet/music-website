using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Repository;
using Framework.Utility.Helper;
using Framework.Utility.ViewModels;
using Microsoft.EntityFrameworkCore; 
using Framework.Admin.Contracts; 
namespace Framework.Admin.Service
{
    public class CollectService : ICollectContract
    {
        private ICollectRepository _collectRepository;

        public CollectService(ICollectRepository collectRepository)
        {
            _collectRepository = collectRepository;
        }
        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TData AddCollection(CollectRequest request)
        {
            var entity = request.MapTo<Biz_Collect>(); 
            var result = _collectRepository.Insert(entity); 
            return result>0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public async Task<TData> CollectionOfUser(int userId)
        { 
            var list = await _collectRepository.QueryAsNoTracking(c=>c.user_id == userId).ToListAsync();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData DeleteCollect(int userId, int songId)
        { 
            var result = _collectRepository.Delete(d=>d.user_id == userId && d.song_id == songId);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData ExistSongId(CollectRequest dto)
        {   
            bool isExist = _collectRepository.CheckExists(d => d.user_id == dto.user_id && d.song_id == dto.song_id);   
            string msg = isExist ? "已收藏" : "未收藏"; 
            return new TData(ResultTag.success, msg,isExist); 
        }
    }
}
