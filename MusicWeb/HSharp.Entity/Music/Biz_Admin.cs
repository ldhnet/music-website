using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSharp.Entity.Music
{
    [Table("Biz_Admin")]
    public class Biz_Admin : BaseMusicExtensionEntity
    { 
        public string UserName { get; set; } 

        public string Password { get; set; } 

    }
}
