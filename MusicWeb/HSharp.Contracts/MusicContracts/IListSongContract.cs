

using HSharp.Models.Request;
using HSharp.Util.Model;

namespace HSharp.Contracts.MusicContracts
{
    public interface IListSongContract
    {
        Task<TData> AddListSong(ListSongRequest dto);

        Task<TData> UpdateListSongMsg(ListSongRequest dto);

        Task<TData> DeleteListSong(int songId);
        Task<TData> ListSongOfSongId(int songListId);
    }
}
