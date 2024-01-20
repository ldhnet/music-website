using HSharp.Models.Request;
using HSharp.Util.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Contracts.MusicContracts
{
    public interface ICommentContract
    {
        Task<TData> AddComment(CommentRequest dto);

        Task<TData> UpdateCommentMsg(CommentLike dto);

        Task<TData> DeleteComment(int id);

        Task<TData> CommentOfSongId(int songId);

        Task<TData> CommentOfSongListId(int songListId);
    }
}
