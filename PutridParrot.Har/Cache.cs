using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Cache object
/// </summary>
public sealed class Cache
{
    /// <summary>
    /// State of the cache entry before the request.
    /// </summary>
    [JsonPropertyName("beforeRequest")]
    public BeforeRequest? BeforeRequest { get; set; }
    /// <summary>
    /// State of the cache entry after the request.
    /// </summary>
    [JsonPropertyName("afterRequest")]
    public AfterRequest? AfterRequest { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}