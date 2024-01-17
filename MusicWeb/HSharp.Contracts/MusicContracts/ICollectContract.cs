using HSharp.Models.Request;
using HSharp.Util.Model; 

namespace HSharp.Contracts.MusicContracts
{
    public interface ICollectContract
    {
        Task<TData> AddCollection(CollectRequest addCollectRequest);

        Task<TData> ExistSongId(CollectRequest isCollectRequest);

        Task<TData> DeleteCollect(int userId, int songId);

        Task<TData> CollectionOfUser(int userId);
    }
}
