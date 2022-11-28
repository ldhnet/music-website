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
    public interface IUserSupportContract
    {
        TData IsUserSupportComment(UserSupportRequest dto);

        TData InsertCommentSupport(UserSupportRequest dto);

        TData DeleteCommentSupport(UserSupportRequest dto);
    }
}
