using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Entity.Music
{
    [Table("Biz_Song")]
    public class Biz_Song : BaseMusicExtensionEntity
    { 
        public int Singer_Id { get; set; }

        public string Name { get; set; }

        public string? Pic { get; set; }

        public string? Introduction { get; set; }
        public string? Lyric { get; set; }

        public string? Url { get; set; }

    }
}
