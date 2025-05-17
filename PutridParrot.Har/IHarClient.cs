namespace PutridParrot.Har;

public interface IHarClient
{
    Har? Deserialize(string har);
    string Serialize(Har har);
}