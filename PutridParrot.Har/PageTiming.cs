using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// PageTiming object
/// </summary>
public sealed class PageTiming
{
    /// <summary>
    /// Number of milliseconds it took to load the page. 
    /// </summary>
    [JsonPropertyName("onContentLoad")]
    public double? OnContentLoad { get; set; } = -1;

    /// <summary>
    /// Number of milliseconds it took to load the page. 
    /// </summary>
    [JsonPropertyName("onLoad")]
    public double? OnLoad { get; set; } = -1;
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary> 
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }   
}