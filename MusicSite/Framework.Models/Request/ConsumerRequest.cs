using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Request
{
    public class ConsumerRequest
    {
        public int id { get; set; }

        public string username { get; set; }

        public string? oldPassword { get; set; }//因为会用到用户旧密码 这无所谓的对应即可

        public string? password { get; set; }

        public int? sex { get; set; }

        public string? phone_num { get; set; }

        public string? email { get; set; }

        public DateTime? birth { get; set; }

        public string? introduction { get; set; }

        public string? location { get; set; }

        public string? avator { get; set; } 
    }
}
