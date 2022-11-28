using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Utility.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Admin.Contracts
{
    public interface ISongListContract
    {
        TData AddSongList(SongListRequest dto);

        TData UpdateSongListMsg(SongListRequest dto);

        TData UpdateSongListPic(int id,string imgPic);

        TData DeleteSongList(int id);

        TData AllSongList();

        TData LikeTitle(string title);

        TData LikeStyle(string style);
    }
}
