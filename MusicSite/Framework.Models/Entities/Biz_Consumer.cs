using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_consumer")]
    public class Biz_Consumer : BaseEntity
    {
        public int id { get; set; }

        public string username { get; set; }

        public string?   password { get; set; }
        public int? sex { get; set; }

        public string? phone_num { get; set; }

        public string? email { get; set; }

        public DateTime? birth { get; set; }

        public string? introduction { get; set; }

        public string? location { get; set; }

        public string? avator { get; set; } 
    }
}
