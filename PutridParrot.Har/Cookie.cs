using System.Text.Json.Serialization;

namespace PutridParrot.Har;

/// <summary>
/// Cookie object
/// </summary>
public sealed class Cookie
{
    /// <summary>
    /// Name of the cookie.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value of the cookie.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Cookie path.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
    /// <summary>
    /// Cookie domain.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    /// <summary>
    /// Cookie expiration date as the number of seconds since the UNIX epoch.
    /// </summary> 
    [JsonPropertyName("expires")]
    public DateTime? Expires { get; set; }
    // TODO: check this is correct
    [JsonPropertyName("hostOnly")] 
    public bool? HostOnly { get; set; }
    /// <summary>
    /// True if the cookie is HTTP only cookie.
    /// </summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }
    /// <summary>
    /// True if the cookie is transmitted over SSL.
    /// </summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
    /// <summary>
    /// Comment provided by the user or application.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }   
}