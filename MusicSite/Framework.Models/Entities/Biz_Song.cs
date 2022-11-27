using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_song")]
    public class Biz_Song: BaseEntity
    {
        public int id { get; set; }
        public int singer_id { get; set; }

        public string name { get; set; }

        public string? pic { get; set; }

        public string? introduction { get; set; }
        public string? lyric { get; set; }

        public string? url { get; set; } 

    }
}
