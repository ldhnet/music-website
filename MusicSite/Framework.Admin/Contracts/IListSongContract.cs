using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Utility.ViewModels; 

namespace Framework.Admin.Contracts
{
    public interface IListSongContract
    {
        TData AddListSong(ListSongRequest dto);

        TData UpdateListSongMsg(ListSongRequest dto);

        TData DeleteListSong(int songId);

        //看看这啥
        List<Biz_List_Song> AllListSong();

        TData ListSongOfSongId(int songListId);
    }
}
