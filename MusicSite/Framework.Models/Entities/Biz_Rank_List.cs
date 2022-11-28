using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{
    [Table("biz_rank_list")]
    public class Biz_Rank_List : BaseEntity
    {
        public int id { get; set; }
        public int songListId { get; set; }
        public int consumerId { get; set; }
        public int score { get; set; } 

    }
}
