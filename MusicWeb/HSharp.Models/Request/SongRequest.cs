using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class SongRequest
    {
        public int Id { get; set; }

        public int Singer_Id { get; set; }

        public string Name { get; set; }

        public string? Introduction { get; set; }

        public string? Pic { get; set; }

        public string? Lyric { get; set; }

        public string? Url { get; set; }

        public DateTime? Create_Time { get; set; }

        public DateTime? Update_Time { get; set; }
    }
}
