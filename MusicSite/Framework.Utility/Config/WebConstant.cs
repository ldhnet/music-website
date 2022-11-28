using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Config
{
    public class WebConstant
    {
        public const string CUL_ZH_CN = "zh-CN";
        public const string CUL_EN = "en";
        public const string DAY = "天";
        public const string HOUR = "小时";

        public static Dictionary<string, Dictionary<string, string>> UnitDict = new Dictionary<string, Dictionary<string, string>>
        {
            {DAY, new Dictionary<string, string> {{CUL_ZH_CN, DAY}, {CUL_EN, "Day"}}},
            {HOUR, new Dictionary<string, string> {{CUL_ZH_CN, HOUR}, {CUL_EN, "Hour"}}}
        };
        /// <summary>
        /// 服务 名称
        /// </summary>
        public const string WorkerServiceName = "ServiceName";

        /// <summary>
        /// Worker Service
        /// </summary>
        public struct WorkerServiceKey
        {
            /// <summary>
            /// RabbitMQ 服务
            /// </summary>
            public const string RabbitMQService = "RabbitMQService";

            /// <summary>
            /// Hangfire 服务
            /// </summary>
            public const string HangfireService = "HangfireService";

            /// <summary>
            /// 项目or业务条线
            /// </summary>
            public static string[] WorkerServiceList = { RabbitMQService, HangfireService };
        }


        public static Dictionary<string, string> WorkerServiceDict = new Dictionary<string, string>
        {
           { WorkerServiceName, CUL_EN }
        };
    }
}
