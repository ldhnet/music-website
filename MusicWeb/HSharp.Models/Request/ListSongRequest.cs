using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class ListSongRequest
    {
        public int Id { get; set; }

        public int Song_Id { get; set; }

        public int Song_List_Id { get; set; }
    }
}
