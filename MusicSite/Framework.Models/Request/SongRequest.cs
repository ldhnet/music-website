using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Request
{
    public class SongRequest
    {
        public int id { get; set; }

        public int singer_id { get; set; }

        public string name { get; set; }

        public string? introduction { get; set; }

        public string? pic { get; set; }

        public string? lyric { get; set; }

        public string? url { get; set; }

        public DateTime? create_time { get; set; }

        public DateTime? update_time { get; set; }
    }
}
