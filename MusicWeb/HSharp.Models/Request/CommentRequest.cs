using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class CommentRequest
    {
        public int Id { get; set; }

        public int User_Id { get; set; }

        public int? Song_Id { get; set; }

        public int? Song_List_Id { get; set; }

        public string? Content { get; set; }

        public int? Type { get; set; } = 0;

        public int? Up { get; set; } = 0;//点赞
    }
}
