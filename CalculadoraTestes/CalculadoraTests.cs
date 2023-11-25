using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arange
        int num1 = 5;
        int num2 = 10;

        // Act
        int result = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, result);
    }
}