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
    public interface ISingerContract
    {
        TData AddSinger(SingerRequest dto);

        TData UpdateSingerMsg(SingerRequest dto);

        TData UpdateSingerPic(int singerId, string singerPic);

        TData DeleteSinger(int id);

        TData AllSinger();

        TData SingerOfName(string name);

        TData SingerOfSex(int sex);


    }
}
