using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Admin.Contracts
{
    public interface ICommentContract
    {  
        TData AddComment(CommentRequest dto);

        TData UpdateCommentMsg(CommentRequest dto);

        TData DeleteComment(int id);

        Task<TData> CommentOfSongId(int songId);

        Task<TData> CommentOfSongListId(int songListId);
    }
}
