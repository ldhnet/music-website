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
    public interface IConsumerContract
    { 
        TData AddUser(ConsumerRequest registryRequest);

        TData UpdateUserMsg(ConsumerRequest dto);

        TData UpdateUserAvator(string avatorFileUrl, int id);

        TData UpdatePassword(ConsumerRequest updatePasswordRequest);

        bool ExistUser(string username);

        bool VerityPasswd(string username, string password);

        TData DeleteUser(int id);

        TData AllUser();

        TData UserOfId(int id);

        TData LoginStatus(ConsumerRequest loginRequest);

    }
}
