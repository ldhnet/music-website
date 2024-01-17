using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class RankListRequest
    {
        public int Id { get; set; }

        public int Song_List_Id { get; set; }

        public int Consumer_id { get; set; }

        public int Score { get; set; }
    }
}
