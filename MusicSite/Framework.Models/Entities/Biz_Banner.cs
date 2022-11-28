using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_banner")]
    public class Biz_Banner : BaseEntity
    {
        public int id { get; set; }
        public string pic { get; set; } 
    }
}
