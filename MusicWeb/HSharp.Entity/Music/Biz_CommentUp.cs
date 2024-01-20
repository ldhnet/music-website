using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSharp.Entity.Music
{
    [Table("Biz_CommentUp")]
    public class Biz_CommentUp : BaseMusicExtensionEntity
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }
    }
}
