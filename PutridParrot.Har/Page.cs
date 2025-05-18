using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Page object
/// </summary>
public sealed class Page
{
    /// <summary>
    /// Date and time for the beginning of the page load.
    /// </summary>
    [JsonPropertyName("startedDateTime")]
    public DateTime? StartedDateTime { get; set; }   
    ///<summary>
    /// Unique identifier of the page within the log.
    /// </summary> 
    [JsonPropertyName("id")]
    //[JsonRequired]
    public string? Id { get; set; }
    /// <summary>
    /// Page title.
    /// </summary>
    [JsonPropertyName("title")]
    //[JsonRequired]
    public string? Title { get; set; }
    /// <summary>
    /// Timing information for the page.
    /// </summary>
    [JsonPropertyName("pageTimings")]
    //[JsonRequired]
    public PageTiming? PageTimings { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary> 
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }   
}