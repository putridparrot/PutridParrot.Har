using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Param object
/// </summary>
public sealed class Param
{
    /// <summary>
    /// Name of the parameter.
    /// </summary>
    [JsonPropertyName("name")]
    //[JsonRequired]
    public string? Name { get; set; }
    /// <summary>
    /// Value of the parameter.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Name of a posted file.
    /// </summary>
    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }
    /// <summary>
    /// Content type of the posted file.
    /// </summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }   
}