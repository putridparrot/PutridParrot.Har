using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Root object for a HAR data
/// </summary>
public sealed class Log
{
    /// <summary>
    /// Format version of the HAR data.
    /// </summary>
    [JsonPropertyName("version")]
    //[JsonRequired]
    public string? Version { get; set; } = "1.2";
    /// <summary>
    /// Name and version of the creator tool.
    /// </summary>
    [JsonPropertyName("creator")]
    //[JsonRequired]
    public Creator? Creator { get; set; }
    /// <summary>
    /// Name and version of the browser.
    /// </summary>
    [JsonPropertyName("browser")]
    public Browser? Browser { get; set; }
    /// <summary>
    /// Collection of pages.
    /// </summary>
    [JsonPropertyName("pages")]
    public Page[]? Pages { get; set; }
    /// <summary>
    /// Collection of requests.
    /// </summary>
    [JsonPropertyName("entries")]
    //[JsonRequired]
    public Entry[]? Entries { get; set; }
    /// <summary>
    /// Optional comment provided by the user.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}