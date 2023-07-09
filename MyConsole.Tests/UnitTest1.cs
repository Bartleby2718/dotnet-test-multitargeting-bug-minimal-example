namespace MyConsole.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PassingTest1()
    {
        Assert.Pass();
    }

    [Test]
    public void FailingTest1()
    {
        Assert.Fail();
    }
}