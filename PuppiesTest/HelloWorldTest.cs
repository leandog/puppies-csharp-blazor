using Puppies.Components.Pages;

namespace PuppiesTest;

using Bunit;
using NUnit.Framework;

public class HelloWorldTest : BunitTestContext
{
    [Test]
    public void HelloWorldComponentRendersCorrectly()
    {
        var cut = RenderComponent<HelloWorld>();
        cut.MarkupMatches("<h1>Hello World</h1>");
    }
}
