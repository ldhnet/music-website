using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Repository;
using Framework.Utility.Helper;
using Framework.Utility.ViewModels;
using Framework.Admin.Contracts; 
namespace Framework.Admin.Service
{
    public class SingerService : ISingerContract
    {
        private ISingerRepository _singerRepository;

        public SingerService(ISingerRepository singerRepository)
        {
            _singerRepository = singerRepository;
        }

        public TData AddSinger(SingerRequest dto)
        {
            var entity = dto.MapTo<Biz_Singer>();
            var result = _singerRepository.Insert(entity);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData AllSinger()
        {
            var list = _singerRepository.EntitiesAsNoTracking.ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData DeleteSinger(int id)
        {
            var result = _singerRepository.Delete(d => d.id == id);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData SingerOfName(string name)
        {
            var list = _singerRepository.QueryAsNoTracking(c=>c.name == name.Trim()).ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData SingerOfSex(int sex)
        {
            var list = _singerRepository.QueryAsNoTracking(c => c.sex == sex).ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData UpdateSingerMsg(SingerRequest dto)
        {
            var entity = _singerRepository.GetByKey(dto.id);
            entity.name = dto.name;
            entity.sex = dto.sex;
            entity.introduction = dto.introduction;
            entity.location = dto.location;
            entity.birth = dto.birth;
            return _singerRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData UpdateSingerPic(int singerId,string singerPic)
        {
            var entity = _singerRepository.GetByKey(singerId);
            entity.pic = singerPic; 
            return _singerRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }
    }
}
