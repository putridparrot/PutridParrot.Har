using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Header object
/// </summary>
public sealed class Header
{
    /// <summary>
    /// Header name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}