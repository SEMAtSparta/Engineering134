using CodeToTest;
namespace UnitTests;

public class Tests
{
    

    [TestCase(5)]
    [TestCase(6)]
    [TestCase(11)]

    public void GivenMorningBoundaryValues_GetGreeting_ReturnsGoodMorning(int timeOfDay)
    {
        int time = timeOfDay;
        string output = Program.GetGreeting(time);
        Assert.That(output, Is.EqualTo("Good morning!"));
    }

    [TestCase(12)]
    [TestCase(14)]
    [TestCase(18)]

    public void GivenAfternoonBoundaryValues_GetGreeting_ReturnsGoodAfternoon(int timeOfDay)
    {
        int time = timeOfDay;
        string output = Program.GetGreeting(time);
        Assert.That(output, Is.EqualTo("Good afternoon!"));
    }

    [TestCase(0)]
    [TestCase(2)]
    [TestCase(4)]
    [TestCase(19)]
    [TestCase(21)]
    [TestCase(23)]

    public void GivenEveningBoundaryValues_GetGreeting_ReturnsGoodEvening(int timeOfDay)
    {
        int time = timeOfDay;
        string output = Program.GetGreeting(time);
        Assert.That(output, Is.EqualTo("Good evening!"));
    }


    /*Specimen Test
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
    }*/
}