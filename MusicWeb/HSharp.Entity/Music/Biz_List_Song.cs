using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Entity.Music
{
    [Table("Biz_List_Song")]
    public class Biz_List_Song : BaseMusicExtensionEntity
    { 
        public int Song_Id { get; set; }

        public int Song_List_Id { get; set; }


    }
}
