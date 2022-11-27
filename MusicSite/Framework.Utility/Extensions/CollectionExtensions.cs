 using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Framework.Utility.Extensions
{
    /// <summary>
    /// 集合扩展方法
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// 如果条件成立，添加项
        /// </summary>
        public static void AddIf<T>(this ICollection<T> collection, T value, bool flag)
        {
            collection.CheckNotNullOrEmpty(nameof(collection));
            if (flag)
            {
                collection.Add(value);
            }
        }

        /// <summary>
        /// 如果条件成立，添加项
        /// </summary>
        public static void AddIf<T>(this ICollection<T> collection, T value, Func<bool> func)
        {
            collection.CheckNotNullOrEmpty(nameof(collection));
            if (func())
            {
                collection.Add(value);
            }
        }

        /// <summary>
        /// 如果不存在，添加项
        /// </summary>
        public static void AddIfNotExist<T>(this ICollection<T> collection, T value, Func<T, bool> existFunc = null)
        {
            collection.CheckNotNullOrEmpty(nameof(collection));
            bool exists = existFunc == null ? collection.Contains(value) : collection.Any(existFunc);
            if (!exists)
            {
                collection.Add(value);
            }
        }

        /// <summary>
        /// 如果不为空，添加项
        /// </summary>
        public static void AddIfNotNull<T>(this ICollection<T> collection, T value) where T : class
        {
            collection.CheckNotNullOrEmpty(nameof(collection));
            if (value != null)
            {
                collection.Add(value);
            }
        }

        /// <summary>
        /// 获取对象，不存在对使用委托添加对象
        /// </summary>
        public static T GetOrAdd<T>(this ICollection<T> collection, Func<T, bool> selector, Func<T> factory)
        {
            collection.CheckNotNullOrEmpty(nameof(collection));
            T item = collection.FirstOrDefault(selector);
            if (item == null)
            {
                item = factory();
                collection.Add(item);
            }

            return item;
        }

        /// <summary>
        /// 判断集合是否为null或空集合
        /// </summary>
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return collection == null || collection.Count == 0;
        }          
    }
}