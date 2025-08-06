namespace tunit_testconfiguration;

public class Tests
{
    [Test]
    public async Task Basic()
    {
        await Assert.That(TestContext.Configuration).IsNotNull();
        var value = TestContext.Configuration.Get("MyKey1");
        await Assert.That(value).IsEqualTo("MyValue1");
    }
}
