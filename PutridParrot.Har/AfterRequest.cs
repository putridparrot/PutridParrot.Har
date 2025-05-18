using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// AfterRequest object
/// </summary>
public sealed class AfterRequest
{
    /// <summary>
    /// Expiration time of the cache entry.
    /// </summary>
    [JsonPropertyName("expires")]
    public string? Expires { get; set; }
    /// <summary>
    /// Last access time of the cache entry.
    /// </summary>
    [JsonPropertyName("lastAccess")]
    //[JsonRequired]
    public string? LastAccess { get; set; }
    /// <summary>
    /// ETag of the cached response.
    /// </summary>
    [JsonPropertyName("eTag")]
    //[JsonRequired]
    public string? ETag { get; set; }
    /// <summary>
    /// Hit count of the cache entry.
    /// </summary>
    [JsonPropertyName("hitCount")]
    //[JsonRequired]
    public int? HitCount { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }  
}