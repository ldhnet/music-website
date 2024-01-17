using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class CollectRequest
    {
        public int Id { get; set; }

        public int User_Id { get; set; }

        public byte Type { get; set; }

        public int Song_Id { get; set; }

        public int Song_List_Id { get; set; }

        public DateTime Create_Time { get; set; }
    }
}
