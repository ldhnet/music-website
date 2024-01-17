using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSharp.Entity.Music
{
    [Table("Biz_Comment")]
    public class Biz_Comment : BaseMusicExtensionEntity
    {

        public int User_Id { get; set; }

        public int? Song_Id { get; set; }

        public int? Song_List_Id { get; set; }

        public string? Content { get; set; }
        public int? Type { get; set; }
        public int? Up { get; set; }

    }
}
