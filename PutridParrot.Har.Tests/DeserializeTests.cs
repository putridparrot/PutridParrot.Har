using System.Reflection;

namespace PutridParrot.Har.Tests;

public class DeserializeTests
{
    private string SampleFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Samples");

    [Test]
    public void Test1()
    {
        // var harClient = new HarClient();
        // var har = harClient.Deserialize(File.ReadAllText(Path.Combine(SampleFolder, "firefox.har")));
        //
        // var i = har.Log.Entries.FirstOrDefault(l => l.Timings.Send is null);
    }

    [Test]
    public void Test2()
    {
        
    }
}