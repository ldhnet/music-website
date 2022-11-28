using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Config
{
    /// <summary>
    /// 
    /// </summary>
    public class Sys_MailInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string[] CCList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string[] AttachmentFiles { get; set; } 
    }
}
