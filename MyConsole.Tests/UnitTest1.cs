namespace MyConsole.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PassingTest1([Values(1, 2)] int value)
    {
        Console.WriteLine(value);
        Assert.Pass();
    }

    [Test]
    public void FailingTest1()
    {
        Assert.Fail();
    }
}