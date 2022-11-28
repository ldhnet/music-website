using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Helper
{
    public class TimeStampHelper
    {
        /// <summary>
        /// 日期转换为时间戳Timestamp
        /// </summary>
        /// <param name="dateTime">要转换的日期</param>
        /// <returns></returns>
        public static long GetTimeStamp(DateTime dateTime)
        {
            DateTime _dtStart = new DateTime(1970, 1, 1, 8, 0, 0);
            //10位的时间戳
            //long timeStamp = Convert.ToInt32(dateTime.Subtract(_dtStart).TotalSeconds);
            //13位的时间戳
            long timeStamp = Convert.ToInt64(dateTime.Subtract(_dtStart).TotalMilliseconds);
            return timeStamp;
        }
        /// <summary>
        /// UTC时间戳Timestamp转换为北京时间
        /// </summary>
        /// <param name="timestamp">要转换的时间戳</param>
        /// <returns></returns>
        public static DateTime GetDateTime(string timeStamp)
        {
            DateTime dtStart = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

    }
}
