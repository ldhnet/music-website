using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class ListSongService : RepositoryFactory, IListSongContract
    {

        public async Task<TData> AddListSong(ListSongRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = dto.MapTo<Biz_List_Song>();
            var result = await _Repository.Insert(entity);
            obj.Data = result > 0;
            return obj;
        }


        public async Task<TData> DeleteListSong(int songId)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var result = await _Repository.Delete<Biz_List_Song>(d => d.Song_Id == songId);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> ListSongOfSongId(int songListId)
        {
            TData<List<Biz_List_Song>> obj = new TData<List<Biz_List_Song>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_List_Song>(c => c.Song_List_Id == songListId);
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> UpdateListSongMsg(ListSongRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = dto.MapTo<Biz_List_Song>();
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }
    }
}
