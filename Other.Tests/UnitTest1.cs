namespace Other.Tests;

public class OtherTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AnotherPassingTest1()
    {
        Assert.Pass();
    }

    [Test]
    public void AnotherFailingTest1()
    {
        Assert.Fail();
    }
}