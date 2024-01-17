using System.ComponentModel.DataAnnotations.Schema;

namespace HSharp.Entity.Music
{
    [Table("Biz_Collect")]
    public class Biz_Collect : BaseMusicExtensionEntity
    {
        public int User_Id { get; set; }
        public int Type { get; set; }


        public int Song_Id { get; set; }

        public int? Song_List_Id { get; set; }

    }
}
