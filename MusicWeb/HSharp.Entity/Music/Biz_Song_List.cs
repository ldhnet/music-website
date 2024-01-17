using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Entity.Music
{
    [Table("Biz_Song_List")]
    public class Biz_Song_List : BaseMusicExtensionEntity
    { 

        public string Title { get; set; }

        public string Pic { get; set; }

        public string Style { get; set; }
        public string Introduction { get; set; }

    }
}
