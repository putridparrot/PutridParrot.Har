namespace PutridParrot.Har.Tests;

public class InitializationTests
{
    [Test]
    public void EnsureRequiredPropertiesAreSet()
    {
        var har = new Har
        {
            Log = new Log
            {
                Creator = new Creator
                {
                    Name = "PutridParrot.Har",
                    Version = "0.0.1"
                },
                Browser = new Browser
                {
                    Name = "PutridParrot.Har",
                    Version = "0.0.1"
                },
                Entries = [],
                Version = "1.2"
            }
        };
        
        var client = new HarClient();
        var serialized = client.Serialize(har);
        var deserialized = client.Deserialize(serialized);

        Assert.That(deserialized, Is.Not.Null);
        Assert.That(client.Serialize(deserialized), Is.EqualTo(serialized));
    }
}