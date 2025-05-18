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
    //[JsonRequired]
    public string? Method { get; set; }
    /// <summary>
    /// Absolute URL of the request (fragments are not included).
    /// </summary>
    [JsonPropertyName("url")]
    //[JsonRequired]
    public string? Url { get; set; }
    /// <summary>
    /// HTTP version used in the request.
    /// </summary>
    [JsonPropertyName("httpVersion")]
    //[JsonRequired]
    public string? HttpVersion { get; set; }
    /// <summary>
    ///  List of cookies included with the request.
    /// </summary>
    [JsonPropertyName("cookies")]
    //[JsonRequired]
    public Cookie[]? Cookies { get; set; }
    /// <summary>
    ///  List of headers included with the request.
    /// </summary> 
    [JsonPropertyName("headers")]
    //[JsonRequired]
    public Header[]? Headers { get; set; }
    /// <summary>
    ///  List of query parameters included with the request.
    /// </summary>
    [JsonPropertyName("queryString")]
    //[JsonRequired]
    public QueryString[]? QueryString { get; set; }
    /// <summary>
    ///  List of post data parameters included with the request.
    /// </summary>
    [JsonPropertyName("postData")]
    public PostData? PostData { get; set; }
    /// <summary>
    /// Total number of bytes from the start of the HTTP request until the end of the body.
    /// </summary>
    [JsonPropertyName("headersSize")]
    //[JsonRequired]
    public int? HeadersSize { get; set; } = -1;

    /// <summary>
    /// Total number of bytes from the start of the HTTP request until the end of the body.
    /// </summary>
    [JsonPropertyName("bodySize")]
    //[JsonRequired]
    public int? BodySize { get; set; } = -1;
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}