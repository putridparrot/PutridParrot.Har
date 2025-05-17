using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Browser object
/// </summary>
public sealed class Browser
{
    /// <summary>
    /// Name of the browser.   
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    ///  Browser version.  
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>  
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }   
}