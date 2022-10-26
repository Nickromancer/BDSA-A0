namespace A0Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var num = 1;
        //Act

        //Assert
        num.Should().Be(2);
    }
}