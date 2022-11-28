using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models.Entities
{ 
    [Table("visitRecord")]
    public class VisitRecord
    {
        public int Id { get; set; }
        public string? Ip { get; set; }
        public string? RequestPath { get; set; }
        public string? RequestQueryString { get; set; }
        public string? RequestMethod { get; set; }
        public string? UserAgent { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
