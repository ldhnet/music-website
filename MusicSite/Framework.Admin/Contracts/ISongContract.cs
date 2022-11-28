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
    public interface ISongContract
    {
        TData AddSong(SongRequest dto, IFormFileCollection mpfile);

        TData UpdateSongMsg(SongRequest dto);

        TData UpdateSongUrl(int id,string songFileUrl);

        TData UpdateSongPic(int id,string imgPic);

        TData DeleteSong(int id);

        TData AllSong();

        TData SongOfSingerId(int singerId);

        TData SongOfId(int id);

        TData SongOfSingerName(string name);
    }
}
