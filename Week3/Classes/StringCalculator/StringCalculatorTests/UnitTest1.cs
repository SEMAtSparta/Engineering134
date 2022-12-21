using StringCalculator;
namespace StringCalculatorTests;

public class Tests
{
    [Ignore("No longer necessary")]
    [Test]
    public void GivenEmptyString_Add_Returns0()
    {
        int output = Program.Add("");
        Assert.That(output, Is.EqualTo(0));
    }

    [Ignore("No longer necessary")]
    [TestCase("1", 1)]
    [TestCase("1,2", 3)]
    [TestCase("1,3,4", 8)]

    public void GivenCommaSeparatedString_Add_ReturnsSumOfNumbers(string input, int expectedResult)
    {
        int output = Program.Add(input);

        Assert.That(output, Is.EqualTo(expectedResult));
    }

    [Ignore("No longer necessary")]
    [TestCase("1\n2,3", 6)]

    public void GivenCommaAndNewlineSeparatedString_Add_ReturnsSumOfNumbers(string input, int expectedResult)
    {
        int output = Program.Add(input);

        Assert.That(output, Is.EqualTo(expectedResult));
    }


}