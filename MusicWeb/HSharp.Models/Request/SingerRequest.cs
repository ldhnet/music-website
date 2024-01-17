using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Models.Request
{
    public class SingerRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Sex { get; set; }

        public string? Pic { get; set; }

        public DateTime? Birth { get; set; }

        public string? Location { get; set; }

        public string? Introduction { get; set; }
    }
}
