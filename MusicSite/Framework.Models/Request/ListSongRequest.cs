using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Request
{
    public class ListSongRequest
    {
        public int id { get; set; }

        public int song_id { get; set; }

        public int song_list_id { get; set; }
    }
}
