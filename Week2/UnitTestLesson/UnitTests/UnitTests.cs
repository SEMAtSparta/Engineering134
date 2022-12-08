using CodeToTest;
namespace UnitTests;

public class Tests
{
    #region GetGreeting Tests
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

    [TestCase(-1)]
    [TestCase(24)]

    public void GivenOutOfRangeValues_GetGreeting_ThrowsException(int timeOfDay)
    {
        int time = timeOfDay;
        Assert.That(() => Program.GetGreeting(timeOfDay), Throws.TypeOf<ArgumentOutOfRangeException>());
    }

    #endregion

    #region Lab Tests
    [TestCase(0, "No films are available.")]                //for range 0-3
    [TestCase(2, "No films are available.")]
    [TestCase(3, "No films are available.")]
    [TestCase(4, "U & PG films are available.")]            //for range 4-11
    [TestCase(5, "U & PG films are available.")]
    [TestCase(11, "U & PG films are available.")]
    [TestCase(12, "U, PG & 12 films are available.")]       //for range 12-14
    [TestCase(13, "U, PG & 12 films are available.")]
    [TestCase(14, "U, PG & 12 films are available.")]
    [TestCase(15, "U, PG, 12 & 15 films are available.")]   //for range 15-17
    [TestCase(16, "U, PG, 12 & 15 films are available.")]
    [TestCase(17, "U, PG, 12 & 15 films are available.")]
    [TestCase(18, "All films are available.")]              //for range 18+
    [TestCase(40, "All films are available.")]


    public void Classification_Tests(int age, string availableFilms)
    {
        int ageOfViewer = age;
        string result = Program.AvailableClassifications(ageOfViewer);
        Assert.That(result, Is.EqualTo(availableFilms));
    }
    [TestCase(-1)]
    public void GivenOutOfRange_Classification_ThrowsException(int age)
    {
        int ageOfViewer = age;
        Assert.That(() => Program.AvailableClassifications(ageOfViewer), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
    
    #endregion

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