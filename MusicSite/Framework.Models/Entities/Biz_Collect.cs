using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_collect")]
    public class Biz_Collect : BaseEntity
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int type { get; set; }


        public int song_id { get; set; }

        public int? song_list_id { get; set; }
         
    }
}
