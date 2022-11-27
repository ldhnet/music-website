using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Request
{
    public class CollectRequest
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public Byte type { get; set; }

        public int song_id { get; set; }

        public int song_list_id { get; set; }

        public DateTime create_time { get; set; }
    }
}
