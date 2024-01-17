
using HSharp.Models.Request;
using HSharp.Util.Model; 

namespace HSharp.Contracts.MusicContracts
{
    public interface ISingerContract
    {
        Task<TData> AddSinger(SingerRequest dto);

        Task<TData> UpdateSingerMsg(SingerRequest dto);

        Task<TData> UpdateSingerPic(int singerId, string singerPic);

        Task<TData> DeleteSinger(int id);

        Task<TData> AllSinger();

        Task<TData> SingerOfName(string name);

        Task<TData> SingerOfSex(int sex);


    }
}
