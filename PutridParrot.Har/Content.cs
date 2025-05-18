using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Content object
/// </summary>
public sealed class Content
{
    /// <summary>
    /// Length of the returned content in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    //[JsonRequired]
    public int? Size { get; set; }
    /// <summary>
    /// Number of bytes saved by compression.
    /// </summary> 
    [JsonPropertyName("compression")]
    public int? Compression { get; set; }
    /// <summary>
    /// MIME type of returned content.
    /// </summary>
    [JsonPropertyName("mimeType")]
    //[JsonRequired]
    public string? MimeType { get; set; }
    /// <summary>
    /// Response body sent from the server or loaded from the browser cache.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
    /// <summary>
    /// Encoding of the response body.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }  
}