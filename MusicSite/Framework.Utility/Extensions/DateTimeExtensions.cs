using System;
using System.Linq;
namespace Framework.Utility.Extensions
{
    /// <summary>
    /// 时间扩展操作类
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 当前时间是否周末
        /// </summary>
        /// <param name="dateTime">时间点</param>
        /// <returns></returns>
        public static bool IsWeekend(this DateTime dateTime)
        {
            DayOfWeek[] weeks = { DayOfWeek.Saturday, DayOfWeek.Sunday };
            return weeks.Contains(dateTime.DayOfWeek);
        }

        /// <summary>
        /// 是否是闰年
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsLeapYear(this DateTime date)
        {
            return (date.Year%4 == 0) && ((date.Year%100 != 0) || (date.Year%400 != 0));
        }

        /// <summary>
        /// 当前时间是否工作日
        /// </summary>
        /// <param name="dateTime">时间点</param>
        /// <returns></returns>
        public static bool IsWeekday(this DateTime dateTime)
        {
            DayOfWeek[] weeks = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
            return weeks.Contains(dateTime.DayOfWeek);
        }

        /// <summary>
        ///  格式化日期
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string Formatted(this DateTime? dateTime, string format = null)
        {
            return format != null  ? (dateTime.HasValue ? dateTime.Value.ToString(format) : "") : (dateTime.HasValue ? dateTime.Value.ToString("yyyy/MM/dd") : "");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string Formatted(this DateTime dateTime, string format = null)
        {
            if (dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue) return string.Empty;
            return dateTime.ToString(format ?? "yyyy/MM/dd");
        }

        /// <summary>
        /// Get the first monday of the selected month
        /// </summary>
        /// <param name="selectedMonth"></param>
        /// <returns></returns>
        public static DateTime GetFirstMondayOfSelectedMonth(this DateTime selectedMonth)
        {
            var firstMonday = selectedMonth;
            while (firstMonday.DayOfWeek != DayOfWeek.Monday)
            {
                firstMonday = firstMonday.AddDays(1);
            }
            return firstMonday;
        }
    }
}