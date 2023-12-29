namespace DependabotCPMTestClassLib.Tests;

public class SmokeTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Pass()
    {
        Assert.Pass();
    }    
    
    [Test]
    public void SomeClass_Do()
    {
        var s = new SomeClass().Do();
        Assert.Pass();
    }
}