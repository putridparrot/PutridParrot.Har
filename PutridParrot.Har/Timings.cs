using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Timings object
/// </summary>
public sealed class Timings
{
    /// <summary>
    /// Timing spent in a queue waiting for a network connection.
    /// </summary>
    [JsonPropertyName("blocked")]
    public double? Blocked { get; set; } = -1;
    /// <summary>
    /// DNS resolution time. The time required to resolve a host name.
    /// </summary>
    [JsonPropertyName("dns")]
    public double? Dns { get; set; } = -1;
    /// <summary>
    /// Time require for SSL/TLS negotiation.
    /// </summary>
    [JsonPropertyName("ssl")]
    public double? Ssl { get; set; } = -1;
    /// <summary>
    /// Time required to create TCP connection.
    /// </summary>
    [JsonPropertyName("connect")]
    public double? Connect { get; set; } = -1;
    /// <summary>
    /// Time required to send HTTP request to the server.
    /// </summary>
    [JsonPropertyName("send")]
    ////[JsonRequired]
    public double? Send { get; set; }
    /// <summary>
    /// Waiting for a response from the server.
    /// </summary>
    [JsonPropertyName("wait")]
    ////[JsonRequired]
    public double? Wait { get; set; }
    /// <summary>
    /// Time required to receive entire response from the server (or cache).
    /// </summary>  
    [JsonPropertyName("receive")]
    ////[JsonRequired]
    public double? Receive { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary> 
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}