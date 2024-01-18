using HSharp.Entity.Music;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Models.Entities
{
    [Table("Biz_Banner")]
    public class Biz_Banner : BaseMusicExtensionEntity
    { 
        public string Pic { get; set; } 
    }
}
