using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_comment")]
    public class Biz_Comment:BaseEntity
    {
        //[Key] //主键 
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //设置自增
        public int id { get; set; }

        public int user_id { get; set; }

        public int? song_id { get; set; }

        public int? song_list_id { get; set; }

        public string? content { get; set; }
        public int? type { get; set; } 
        public int? up { get; set; }
          
    }
}
