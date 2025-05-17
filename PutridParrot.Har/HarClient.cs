using System.Text.Json;

namespace PutridParrot.Har;

public class HarClient : IHarClient
{
    public Har? Deserialize(string har) =>
        JsonSerializer.Deserialize<Har>(har);
    
    public string Serialize(Har har) =>
        JsonSerializer.Serialize(har);

    public Har? Redact(Har? input)
    {
        ArgumentNullException.ThrowIfNull(input);
        
        // make Har support ICloneable?
        var copy = Deserialize(Serialize(input));
        if (copy?.Log?.Entries is null)
        {
            return copy;
        }

        foreach (var log in copy.Log.Entries)
        {
            if (log.Request?.Headers is not null)
            {
                foreach (var requestHeader in log.Request.Headers)
                {
                    var name = requestHeader.Name;
                    if (name is not null && (name.StartsWith("Authorization") || name.StartsWith("Cookie")))
                    {
                        requestHeader.Value = "REDACTED";
                    }
                }
            }
        }
        
        return copy;
    }
}