using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Request
{
    public class CommentRequest 
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int? song_id { get; set; }

        public int? song_list_id { get; set; }

        public string? content { get; set; }

        public int? type { get; set; } = 0;

        public int? up { get; set; } = 0;//点赞
    }
}
