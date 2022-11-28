using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Request
{
    public class UserSupportRequest
    {
        public int id { get; set; }
        public int commentId { get; set; }
        public int userId { get; set; }
    }
}
