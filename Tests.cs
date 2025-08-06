namespace tunit_testconfiguration;

public class Tests
{
    [Test]
    public void Basic()
    {
        Console.WriteLine("This is a basic test");
    }
}

public sealed class Hooks
{
    [AfterEvery(Test)]
    public static void AfterTest(TestContext testContext)
    {
        Console.WriteLine("After every test");
    }

    [After(Class)]
    public static void AfterTestClass()
    {
        Console.WriteLine("After test class");
    }

    [AfterEvery(Class)]
    public static void AfterEveryTestClass()
    {
        Console.WriteLine("After every test class");
    }

    [After(Assembly)]
    public static void AfterTestAssembly()
    {
        Console.WriteLine("After test assembly");
    }

    [AfterEvery(Assembly)]
    public static void AfterEveryTestAssembly()
    {
        Console.WriteLine("After every test assembly");
    }

    [After(TestSession)]
    public static void AfterTestSession()
    {
        Console.WriteLine("After test session");
    }

    [AfterEvery(TestSession)]
    public static void AfterEveryTestSession()
    {
        Console.WriteLine("After every test session");
    }

    [After(TestDiscovery)]
    public static void AfterTestDiscovery()
    {
        Console.WriteLine("After test discovery");
    }

    [AfterEvery(TestDiscovery)]
    public static void AfterEveryTestDiscovery()
    {
        Console.WriteLine("After every test discovery");
    }
}
