using System.Text.Json.Serialization;

namespace TestRail_Core.Models;

public record Section
{
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
}