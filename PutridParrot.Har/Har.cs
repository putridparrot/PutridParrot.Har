using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// The Har object
/// </summary>
public sealed class Har
{
    /// <summary>
    /// The log object is the root object of the HAR.
    /// </summary>
    [JsonPropertyName("log")]
    public Log? Log { get; set; }
}