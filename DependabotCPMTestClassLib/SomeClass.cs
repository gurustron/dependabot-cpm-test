using Newtonsoft.Json;

namespace DependabotCPMTestClassLib;

public class SomeClass
{
    public string Do() => JsonConvert.SerializeObject(new { name = "Test" });
}