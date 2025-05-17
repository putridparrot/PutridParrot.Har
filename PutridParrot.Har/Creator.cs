using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Creator object
/// </summary>
public sealed class Creator
{
    /// <summary>
    /// Name of the creator tool.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Version of the creator tool.   
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>   
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }   
}