using Framework.Utility.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Models.Entities
{
    [Table("biz_admin")]
    public class Biz_Admin : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }  
        public string password { get; set; } 
    }
 
}
