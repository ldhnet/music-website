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
    public class ListSongService : IListSongContract
    {
        private IListSongRepository _listSongRepository;

        public ListSongService(IListSongRepository listSongRepository)
        {
            _listSongRepository = listSongRepository;
        }

        public TData AddListSong(ListSongRequest dto)
        {
            var entity = dto.MapTo<Biz_List_Song>();
            var result = _listSongRepository.Insert(entity);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public List<Biz_List_Song> AllListSong()
        {
            var list = _listSongRepository.EntitiesAsNoTracking.ToList();      
            return list;
        }

        public TData DeleteListSong(int songId)
        {
            var result = _listSongRepository.Delete(d => d.song_id == songId);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData ListSongOfSongId(int songListId)
        {
            var list = _listSongRepository.QueryAsNoTracking(c => c.song_list_id == songListId).ToList();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData UpdateListSongMsg(ListSongRequest dto)
        {
            var entity = dto.MapTo<Biz_List_Song>();
            return _listSongRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }
    }
}
