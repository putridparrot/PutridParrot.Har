using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Information about the request.
/// </summary>
public sealed class Request
{
    /// <summary>
    /// Request method.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }
    /// <summary>
    /// Absolute URL of the request (fragments are not included).
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    /// <summary>
    /// HTTP version used in the request.
    /// </summary>
    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }
    /// <summary>
    ///  List of cookies included with the request.
    /// </summary>
    [JsonPropertyName("cookies")]
    public Cookie[]? Cookies { get; set; }
    /// <summary>
    ///  List of headers included with the request.
    /// </summary> 
    [JsonPropertyName("headers")]
    public Header[]? Headers { get; set; }
    /// <summary>
    ///  List of query parameters included with the request.
    /// </summary>
    [JsonPropertyName("queryString")]
    public QueryString[]? QueryString { get; set; }
    /// <summary>
    ///  List of post data parameters included with the request.
    /// </summary>
    [JsonPropertyName("postData")]
    public PostData? PostData { get; set; }
    /// <summary>
    ///  Number of milliseconds elapsed since the start of the browser loading the page.
    /// </summary>
    [JsonPropertyName("time")]
    public double? Time { get; set; }
    /// <summary>
    /// Total number of bytes from the start of the HTTP request until the end of the body.
    /// </summary>
    [JsonPropertyName("headersSize")]
    public int? HeadersSize { get; set; }
    /// <summary>
    /// Total number of bytes from the start of the HTTP request until the end of the body.
    /// </summary>
    [JsonPropertyName("bodySize")]
    public int? BodySize { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}