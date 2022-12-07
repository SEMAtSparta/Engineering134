using ExceptionsApp;

namespace ExceptionsTests;

public class Tests
{
    [TestCase(-1)]
    [TestCase(-99)]
    
    public void WhenMarkIsLessThan0_Grade_ThrowsArgumentOutOfRangeException(int mark)
    {
        Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>());
        
        //if you want to check the exception message
        //Assert.That(() => Program.Grade(mark), Throws.Typeof<ArgumentOutOfRangeException>().With.Message.Contain("message to be used in the exception"))
    }
}