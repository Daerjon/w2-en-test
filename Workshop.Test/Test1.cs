using Workshop.Lib;

namespace Workshop.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TemperatureConverter_Zero_Valid()
    {
        //Arrange
        double temperature = 0;
        //Act
        double result = TemperatureConverter.CelciusToFarenheit(temperature);
        //Assert
        Assert.AreEqual(32, result, 1e-7);
    }
}
