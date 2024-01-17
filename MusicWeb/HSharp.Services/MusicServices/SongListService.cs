using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class SongListService : RepositoryFactory, ISongListContract
    {
        public async Task<TData> AddSongList(SongListRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = dto.MapTo<Biz_Song_List>();
            var result = await _Repository.Insert(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> AllSongList()
        {
            TData<List<Biz_Song_List>> obj = new TData<List<Biz_Song_List>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Song_List>();
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> DeleteSongList(int id)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var result = await _Repository.Delete<Biz_Song_List>(d => d.Id == id);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> LikeStyle(string style)
        {
            TData<List<Biz_Song_List>> obj = new TData<List<Biz_Song_List>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Song_List>(c => c.Style == style.Trim());
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> LikeTitle(string title)
        {
            TData<List<Biz_Song_List>> obj = new TData<List<Biz_Song_List>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Song_List>(c => c.Title == title.Trim());
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> UpdateSongListMsg(SongListRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = await _Repository.FindEntity<Biz_Song_List>(c => c.Id == dto.Id);
            entity.Style = dto.Style;
            entity.Title = dto.Title;
            entity.Introduction = dto.Introduction;
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> UpdateSongListPic(int id, string imgPic)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = await _Repository.FindEntity<Biz_Song_List>(c => c.Id == id);
            entity.Pic = imgPic;
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }
    }
}
