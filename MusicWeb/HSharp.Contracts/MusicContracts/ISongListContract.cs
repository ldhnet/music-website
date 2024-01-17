
using HSharp.Models.Request;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Contracts.MusicContracts
{
    public interface ISongListContract
    {
        Task<TData> AddSongList(SongListRequest dto);

        Task<TData> UpdateSongListMsg(SongListRequest dto);

        Task<TData> UpdateSongListPic(int id, string imgPic);

        Task<TData> DeleteSongList(int id);

        Task<TData> AllSongList();

        Task<TData> LikeTitle(string title);

        Task<TData> LikeStyle(string style);
    }
}
