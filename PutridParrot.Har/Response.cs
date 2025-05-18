using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Information about the response.
/// </summary>
public sealed class Response
{
    /// <summary>
    ///  HTTP response status code.
    /// </summary>
    [JsonPropertyName("status")]
    //[JsonRequired]
    public int? Status { get; set; }
    /// <summary>
    ///  HTTP response status text.
    /// </summary>
    [JsonPropertyName("statusText")]
    //[JsonRequired]
    public string? StatusText { get; set; }
    /// <summary>
    ///  HTTP response HTTP version.
    /// </summary>
    [JsonPropertyName("httpVersion")]
    //[JsonRequired]
    public string? HttpVersion { get; set; }
    /// <summary>
    ///  List of headers included with the response.
    /// </summary>
    [JsonPropertyName("headers")]
    //[JsonRequired]
    public Header[]? Headers { get; set; }
    /// <summary>
    ///  List of cookies included with the response.
    /// </summary>
    [JsonPropertyName("cookies")]
    //[JsonRequired]
    public Cookie[]? Cookies { get; set; }
    /// <summary>
    ///  List of content included with the response.
    /// </summary>
    [JsonPropertyName("content")]
    //[JsonRequired]
    public Content? Content { get; set; }
    /// <summary>
    ///  Redirect URL from the response headers.
    /// </summary>
    [JsonPropertyName("redirectURL")]
    //[JsonRequired]
    public string? RedirectUrl { get; set; }
    /// <summary>
    /// Total number of bytes from the start of the HTTP response until the end of the body.
    /// </summary>
    [JsonPropertyName("headersSize")]
    //[JsonRequired]
    public int? HeadersSize { get; set; } = -1;
    /// <summary>
    /// Total number of bytes from the start of the HTTP response until the end of the body.
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