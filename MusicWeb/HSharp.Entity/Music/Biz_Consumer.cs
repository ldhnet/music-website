using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Entity.Music
{
    [Table("Biz_Consumer")]
    public class Biz_Consumer : BaseMusicExtensionEntity
    {

        public string? UserName { get; set; }

        public string? Password { get; set; }
        public int? Sex { get; set; }

        public string? Phone_Num { get; set; }

        public string? Email { get; set; }

        public DateTime? Birth { get; set; }

        public string? Introduction { get; set; }

        public string? Location { get; set; }

        public string? Avator { get; set; }
    }
}
