using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// QueryString object
/// </summary>
public sealed class QueryString
{
    /// <summary>
    /// Query string parameter name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Query string parameter value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}