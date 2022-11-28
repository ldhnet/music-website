
using System.Text.Json;
using System.Text.Json.Serialization;
public class JsonTimeOnlyConverter : JsonConverter<TimeOnly>
{
    public string Format { get; set; } = "HH:mm:ss";
    public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => TimeOnly.Parse(reader.GetString());
    public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString(this.Format));
}