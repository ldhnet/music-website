using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Request
{
    public class SongListRequest
    {
        public int id { get; set; }

        public string title { get; set; }

        public string? pic { get; set; }

        public string? style { get; set; }

        public string? introduction { get; set; }
    }
}
