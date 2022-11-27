using Framework.Utility.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Framework.Utility.Helper
{
    #region JsonHelper
    public static class JsonHelper
    {
        public static T ToObject<T>(this string Json)
        {
            Json = Json.Replace("&nbsp;", "");
            return Json == null ? default(T) : JsonConvert.DeserializeObject<T>(Json);
        }

        public static JObject ToJObject(this string Json)
        {
            return Json == null ? JObject.Parse("{}") : JObject.Parse(Json.Replace("&nbsp;", ""));
        }
        /// <summary>
        /// 处理Json的时间格式为正常格式
        /// </summary>
        public static string JsonDateTimeFormat(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) return string.Empty;
            json = Regex.Replace(json,
                @"\\/Date\((\d+)\)\\/",
                match =>
                {
                    DateTime dt = new DateTime(1970, 1, 1);
                    dt = dt.AddMilliseconds(long.Parse(match.Groups[1].Value));
                    dt = dt.ToLocalTime();
                    return dt.ToString("yyyy-MM-dd HH:mm:ss.fff");
                });
            return json;
        }
        /// <summary>
        /// 把对象序列化成Json字符串格式
        /// </summary>
        /// <param name="object"></param>
        /// <returns></returns>
        public static string ToJson(object @object)
        {
            string json = JsonConvert.SerializeObject(@object);
            return JsonDateTimeFormat(json);
        }

        /// <summary>
        /// 把Json字符串转换为强类型对象
        /// </summary>
        public static T FromJson<T>(string json)
        {
            json = JsonDateTimeFormat(json);
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
    #endregion

    #region JsonConverter
    /// <summary>
    /// Json数据返回到前端js的时候，把数值很大的long类型转成字符串
    /// </summary>
    public class StringJsonConverter : JsonConverter
    {
        public StringJsonConverter() { }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
           return Convert.ToInt64(reader.Value); 
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            string sValue = value.ToString();
            writer.WriteValue(sValue);
        }
    }

    /// <summary>
    /// DateTime类型序列化的时候，转成指定的格式
    /// </summary>
    public class DateTimeJsonConverter : JsonConverter
    {
        public DateTimeJsonConverter() { }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Convert.ToDateTime(reader?.Value?.ToString());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            DateTime? dt = value as DateTime?;
            if (dt == null)
            {
                writer.WriteNull();
                return;
            }
            writer.WriteValue(dt.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
    #endregion
}
