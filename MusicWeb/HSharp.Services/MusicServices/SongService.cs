using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Http;

namespace HSharp.Services.MusicServices
{
    public class SongService : RepositoryFactory, ISongContract
    {

        public async Task<TData> AddSong(SongRequest dto, IFormFileCollection mpfile)
        {
            throw new NotImplementedException();
        }

        public async Task<TData> AllSong()
        {
            TData<List<Biz_Song>> obj = new TData<List<Biz_Song>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Song>();
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> DeleteSong(int id)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var result = await _Repository.Delete<Biz_Song>(d => d.Id == id);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> SongOfId(int id)
        {
            TData<List<Biz_Song>> obj = new TData<List<Biz_Song>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Song>(c => c.Id == id);
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> SongOfSingerId(int singerId)
        {
            TData<List<Biz_Song>> obj = new TData<List<Biz_Song>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Song>(c => c.Singer_Id == singerId);
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> SongOfSingerName(string name)
        {
            TData<List<Biz_Song>> obj = new TData<List<Biz_Song>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Song>(c => c.Name.Contains(name.Trim()));
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> UpdateSongMsg(SongRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = await _Repository.FindEntity<Biz_Song>(c => c.Id == dto.Id);
            entity.Name = dto.Name;
            entity.Introduction = dto.Introduction;
            entity.Lyric = dto.Lyric;
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;

        }

        public async Task<TData> UpdateSongPic(int id, string imgPic)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = await _Repository.FindEntity<Biz_Song>(c => c.Id == id);
            entity.Pic = imgPic;
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> UpdateSongUrl(int id, string songFileUrl)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = await _Repository.FindEntity<Biz_Song>(c => c.Id == id);
            entity.Url = songFileUrl;
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }
    }
}
