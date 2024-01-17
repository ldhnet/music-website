
using HSharp.Models.Request;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Http; 
namespace HSharp.Contracts.MusicContracts
{
    public interface ISongContract
    { 
        Task<TData> AddSong(SongRequest dto, IFormFileCollection mpfile);

        Task<TData> UpdateSongMsg(SongRequest dto);

        Task<TData> UpdateSongUrl(int id, string songFileUrl);

        Task<TData> UpdateSongPic(int id, string imgPic);

        Task<TData> DeleteSong(int id);

        Task<TData> AllSong();

        Task<TData> SongOfSingerId(int singerId);

        Task<TData> SongOfId(int id);

        Task<TData> SongOfSingerName(string name);
    }
}
