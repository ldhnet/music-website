using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class ConsumerRequest
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string? OldPassword { get; set; }//因为会用到用户旧密码 这无所谓的对应即可

        public string? Password { get; set; }

        public int? Sex { get; set; }

        public string? Phone_Num { get; set; }

        public string? Email { get; set; }

        public DateTime? Birth { get; set; }

        public string? Introduction { get; set; }

        public string? Location { get; set; }

        public string? Avator { get; set; }
    }
}
