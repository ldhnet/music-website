using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class UserSupportRequest
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
    }
}
