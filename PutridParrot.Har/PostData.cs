using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// PostData object
/// </summary>
public sealed class PostData
{
    /// <summary>
    /// Mime type of posted data.
    /// </summary>
    [JsonPropertyName("mimeType")]
    //[JsonRequired]
    public string? MimeType { get; set; }

    /// <summary>
    /// Posted data params.
    /// </summary>
    [JsonPropertyName("params")]
    //[JsonRequired]
    public Param[]? Params { get; set; }
    /// <summary>
    /// Text of the posted data.
    /// </summary>
    [JsonPropertyName("text")]
    //[JsonRequired]
    public string? Text { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}