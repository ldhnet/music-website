using Framework.Models.Entities;
using HSharp.Util.Model;

namespace HSharp.Contracts.MusicContracts
{
    public interface IBannerContract
    {
        Task<TData> GetAllBanner();
    }
}
