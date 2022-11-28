using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_song_list")]
    public class Biz_Song_List : BaseEntity
    {
        public int id { get; set; }

        public string title { get; set; }

        public string pic { get; set; }

        public string style { get; set; }
        public string introduction { get; set; }   

    }
}
