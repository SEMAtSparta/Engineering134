using RomanNumerals;
namespace RomanNumeralTests;

public class Tests
{
    [TestCase(1,"I")]
    [TestCase(4,"IV")]
    [TestCase(5,"V")]
    [TestCase(6,"VI")]
    [TestCase(9,"IX")]
    [TestCase(10,"X")]
    [TestCase(11,"XI")]
    [TestCase(14,"XIV")]
    [TestCase(15,"XV")]
    [TestCase(16,"XVI")]
    [TestCase(19,"XIX")]
    [TestCase(20,"XX")]
    [TestCase(30,"XXX")]
    [TestCase(40,"XL")]
    [TestCase(45,"XLV")]
    [TestCase(49,"XLIX")]
    [TestCase(90,"XC")]



    public void GivenInt_ConvertIntToRomanNumeral_ReturnsString(int input, string expectedResult)
    {
        string result = Program.ConvertIntToRomanNumerals(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}