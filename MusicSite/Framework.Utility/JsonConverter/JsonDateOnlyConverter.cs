
using System.Text.Json;
using System.Text.Json.Serialization;
public class JsonDateOnlyConverter : JsonConverter<DateOnly>
{
    public string Format { get; set; } = "yyyy-MM-dd";
    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => DateOnly.Parse(reader.GetString());
    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString(this.Format));
}