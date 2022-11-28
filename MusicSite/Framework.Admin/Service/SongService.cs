using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Repository;
using Framework.Utility.Helper;
using Framework.Utility.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Admin.Contracts; 
namespace Framework.Admin.Service
{
    public class SongService : ISongContract
    {
        private ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public TData AddSong(SongRequest dto, IFormFileCollection mpfile)
        {
            throw new NotImplementedException();
        }

        public TData AllSong()
        {
            var list = _songRepository.EntitiesAsNoTracking.ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData DeleteSong(int id)
        {
            var result = _songRepository.Delete(d => d.id == id);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData SongOfId(int id)
        {  
            var list = _songRepository.QueryAsNoTracking(c => c.id == id).ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData SongOfSingerId(int singerId)
        {
            var list = _songRepository.QueryAsNoTracking(c=>c.singer_id == singerId).ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData SongOfSingerName(string name)
        {
            var list = _songRepository.QueryAsNoTracking(c => c.name.Contains(name.Trim())).ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData UpdateSongMsg(SongRequest dto)
        {
          //  var entity = dto.MapTo<Biz_Song>(); 
            var entity = _songRepository.GetFirstOrDefault(c => c.id == dto.id); 
            entity.name = dto.name;
            entity.introduction = dto.introduction;
            entity.lyric = dto.lyric; 
            return _songRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData UpdateSongPic(int id, string imgPic)
        {
            var entity = _songRepository.GetFirstOrDefault(c => c.id == id);
            entity.pic = imgPic; 
            return _songRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData UpdateSongUrl(int id, string songFileUrl)
        {
            var entity = _songRepository.GetFirstOrDefault(c => c.id == id);
            entity.url = songFileUrl;
            return _songRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }
    }
}
