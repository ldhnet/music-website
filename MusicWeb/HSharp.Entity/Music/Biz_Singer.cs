using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Entity.Music
{
    [Table("Biz_Singer")]
    public class Biz_Singer : BaseMusicExtensionEntity
    { 
        public string Name { get; set; }
        public int? Sex { get; set; }

        public string? Pic { get; set; }

        public DateTime? Birth { get; set; }

        public string? Location { get; set; }

        public string? Introduction { get; set; }


    }
}
