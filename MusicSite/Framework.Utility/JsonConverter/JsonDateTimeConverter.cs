
using System.Text.Json;
using System.Text.Json.Serialization;
public class JsonDateTimeConverter : JsonConverter<DateTime>
{
    public string Format { get; set; } = "yyyy-MM-dd HH:mm:ss";
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => DateTime.Parse(reader.GetString());
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString(this.Format));
}