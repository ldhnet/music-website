
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
    public interface IUserSupportContract
    {
        Task<TData> IsUserSupportComment(UserSupportRequest dto);

        Task<TData> InsertCommentSupport(UserSupportRequest dto);

        Task<TData> DeleteCommentSupport(UserSupportRequest dto);
    }
}
