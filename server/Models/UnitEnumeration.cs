using System.Text.Json.Serialization;

namespace server.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnitEnumeration
    {
        pcs,
        g,
        kg,
        ml,
        l
    }
}
