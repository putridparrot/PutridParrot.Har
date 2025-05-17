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
    public int? Status { get; set; }
    /// <summary>
    ///  HTTP response status text.
    /// </summary>
    [JsonPropertyName("statusText")]
    public string? StatusText { get; set; }
    /// <summary>
    ///  HTTP response HTTP version.
    /// </summary>
    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }
    /// <summary>
    ///  List of headers included with the response.
    /// </summary>
    [JsonPropertyName("headers")]
    public Header[]? Headers { get; set; }
    /// <summary>
    ///  List of cookies included with the response.
    /// </summary>
    [JsonPropertyName("cookies")]
    public Cookie[]? Cookies { get; set; }
    /// <summary>
    ///  List of content included with the response.
    /// </summary>
    [JsonPropertyName("content")]
    public Content? Content { get; set; }
    /// <summary>
    ///  Redirect URL from the response headers.
    /// </summary>
    [JsonPropertyName("redirectURL")]
    public string? RedirectUrl { get; set; }
    /// <summary>
    ///  Number of milliseconds elapsed since the start of the browser loading the page.
    /// </summary>
    [JsonPropertyName("time")]
    public double? Time { get; set; }
    /// <summary>
    /// Total number of bytes from the start of the HTTP response until the end of the body.
    /// </summary>
    [JsonPropertyName("headerSize")]
    public int? HeaderSize { get; set; }
    /// <summary>
    /// Total number of bytes from the start of the HTTP response until the end of the body.
    /// </summary>
    [JsonPropertyName("bodySize")]
    public int? BodySize { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}