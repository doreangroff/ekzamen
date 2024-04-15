using ekzamen;

namespace Tests;

public class Tests
{
    
    [Test]
    public void Test1()
    {
        //Arrange
        double v = 15;
        double expected = 3.06;
        UnitTestClass test = new UnitTestClass();
        //Act
        double actual = test.CalcT(v);
        //Assert
        Assert.Equals(expected, actual);

    }
    
    [Test]
    public void Test2()
    {
        //Arrange
        double v = 15;
        double expected = 4.06;
        UnitTestClass test = new UnitTestClass();
        //Act
        double actual = test.CalcT(v);
        //Assert
        Assert.Equals(expected, actual);

    }
}