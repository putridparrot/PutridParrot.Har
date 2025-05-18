using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Entry object
/// </summary>
public sealed class Entry
{
    /// <summary>
    /// Reference to the parent page
    /// </summary>
    [JsonPropertyName("pageref")]
    public string? PageRef { get; set; }
    /// <summary>
    /// Date and time of the request start.
    /// </summary>
    [JsonPropertyName("startedDateTime")]
    //[JsonRequired]
    public DateTime? StartedDateTime { get; set; }

    /// <summary>
    ///  Number of milliseconds elapsed of the request.
    /// </summary>
    [JsonPropertyName("time")]
    //[JsonRequired]
    public double? Time { get; set; } = 0;
    /// <summary>
    /// Information about the cache usage.
    /// </summary>
    [JsonPropertyName("cache")]
    //[JsonRequired]
    public Cache? Cache { get; set; }
    /// <summary>
    /// Unique Id of the parent TCP/IP connection, can be the client port number.
    /// </summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }
    /// <summary>
    /// Information about the request.
    /// </summary>
    [JsonPropertyName("request")]
    //[JsonRequired]
    public Request? Request { get; set; }
    /// <summary>
    /// Information about the response.
    /// </summary>   
    [JsonPropertyName("response")]
    //[JsonRequired]
    public Response? Response { get; set; }
    /// <summary>
    /// The IP address of the server that handled the request.
    /// </summary> 
    [JsonPropertyName("serverIPAddress")]
    public string? ServerIpAddress { get; set; }
    /// <summary>
    /// Timing information for the request/response round trip.
    /// </summary>
    [JsonPropertyName("timings")]
    //[JsonRequired]
    public Timings? Timings { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }   
}