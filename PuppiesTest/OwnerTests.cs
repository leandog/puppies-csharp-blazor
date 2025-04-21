using Puppies;

namespace PuppiesTest;

[TestFixture]
public class OwnerTests
{
    [Test]
    public void CreateOwner()
    {
        var bryan = new PuppyOwner();
        Assert.That(typeof(PuppyOwner), Is.EqualTo(bryan.GetType()));
    }    
}