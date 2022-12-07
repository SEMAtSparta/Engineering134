using CodeToTest;
namespace UnitTests;

public class Tests
{

    [Test]
    public void GivenTimeOf21_GetGreeting_ReturnsGoodEvening()
    {
        //given a time of 21
        //A.rrange a precondition
        int time = 21;

        //when I call GetGreeting
        //A.ct
        string output = Program.GetGreeting(time);

        //then
        //A.ssert that it returned "Good evening!"
        Assert.That(output, Is.EqualTo("Good evening!"));
    }

    [Test]
    public void GivenTimeOf11_GetGreeting_ReturnsGoodMorning()
    {
        int time = 11;
        string output = Program.GetGreeting(time);
        Assert.That(output, Is.EqualTo("Good morning!"));
    }

    [Test]
    public void GivenTimeOf14_GetGreeting_ReturnsGoodAfternoon()
    {
        int time = 14;
        string output = Program.GetGreeting(time);
        Assert.That(output, Is.EqualTo("Good afternoon!"));
    }
}