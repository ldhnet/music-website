using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Entity.Music
{
    [Table("Biz_Rank_List")]
    public class Biz_Rank_List : BaseMusicExtensionEntity
    { 
        public int SongListId  { get; set; }
        public int ConsumerId  { get; set; }
        public int Score  { get; set; }

    }
}
