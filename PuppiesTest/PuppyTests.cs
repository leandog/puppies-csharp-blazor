using Puppies;

namespace PuppiesTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void CreatePuppy()
    {
        var butch = new Puppy("Butch");
        Assert.That(typeof(Puppy), Is.EqualTo(butch.GetType()));
    }
    
    [Ignore("asdf")]
    [Test]
    public void CreatePuppyList()
    {
        // var puppyList = new PuppyList();
        // Assert.AreEqual(0, puppyList.totalPuppies());
    }

    [Ignore("NYI")]
    [Test]
    public void AddPuppyToList()
    {
        var butch = new Puppy("Butch");
        // PuppyList

    }
}