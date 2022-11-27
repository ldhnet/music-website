using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.ViewModels
{
    public class BaseEntity
    {
        public string? create_by { get; set; }  
        public DateTime create_time { get; set; }
        public string? update_by { get; set; }
        public DateTime? update_time { get; set; }
    }
}
