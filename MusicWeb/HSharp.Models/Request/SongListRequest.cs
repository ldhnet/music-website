using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class SongListRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Pic { get; set; }

        public string? Style { get; set; }

        public string? Introduction { get; set; }
    }
}
