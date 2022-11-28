using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Framework.Utility.Extensions
{
    /// <summary>
    /// 枚举<see cref="Enum"/>的扩展辅助操作方法
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// 获取枚举项上的<see cref="DescriptionAttribute"/>特性的文字描述
        /// </summary>
        /// <param name="value">枚举类</param>
        /// <returns></returns>
        public static string ToDescription(this Enum value)
        {
            object[]? array = value.GetType().GetField(value.ToString())?.GetCustomAttributes(typeof(DescriptionAttribute), inherit: true);
            if (array != null)
            {
                var attr = array.FirstOrDefault(x => x is DescriptionAttribute);
                if (attr != null)
                {
                    return ((DescriptionAttribute)attr).Description;
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// 枚举类转成Dictionary集合
        /// </summary>
        /// <param name="value">枚举类</param>
        /// <returns></returns>
        public static Dictionary<int,string> ToEnumForDictionary(this Type type)
        { 
            var _values = Enum.GetValues(type).Cast<object>();
            return _values.ToDictionary(k => (int)k, v => ((Enum)v).ToDescription());
        } 
    } 
}