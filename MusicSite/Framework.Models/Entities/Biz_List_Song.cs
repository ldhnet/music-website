using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_list_song")]
    public class Biz_List_Song : BaseEntity
    {
        public int id { get; set; } 

        public int song_id { get; set; }

        public int song_list_id { get; set; }
          

    }
}
