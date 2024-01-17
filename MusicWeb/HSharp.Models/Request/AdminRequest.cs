using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class AdminRequest
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
    public class LoginRequest
    { 

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
