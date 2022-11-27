using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_singer")]
    public class Biz_Singer : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? sex { get; set; }

        public string? pic { get; set; }

        public DateTime? birth { get; set; }

        public string? location { get; set; }

        public string? introduction { get; set; }
         

    }
}
