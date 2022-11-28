using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Repository;
using Framework.Utility.Helper;
using Framework.Utility.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Framework.Admin.Contracts; 

namespace Framework.Admin.Service
{
    public class SongListService : ISongListContract
    {
        private ISongListRepository _songListRepository;

        public SongListService(ISongListRepository songListRepository)
        {
            _songListRepository = songListRepository;
        }

        public TData AddSongList(SongListRequest dto)
        {
            var entity = dto.MapTo<Biz_Song_List>();
            var result = _songListRepository.Insert(entity);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData AllSongList()
        {
            var list = _songListRepository.EntitiesAsNoTracking.ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData DeleteSongList(int id)
        {
            var result = _songListRepository.Delete(d => d.id == id);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData LikeStyle(string style)
        {
            var list = _songListRepository.EntitiesAsNoTracking.Where(c=>c.style == style.Trim()).ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData LikeTitle(string title)
        {
            var list = _songListRepository.EntitiesAsNoTracking.Where(c => c.title == title.Trim()).ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData UpdateSongListMsg(SongListRequest dto)
        {
            var entity = _songListRepository.GetByKey(dto.id);
            entity.style = dto.style;
            entity.title = dto.title;
            entity.introduction = dto.introduction;
            return _songListRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData UpdateSongListPic(int id, string imgPic)
        {
            var entity = _songListRepository.GetByKey(id);
            entity.pic = imgPic;
            return _songListRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }
    }
}
