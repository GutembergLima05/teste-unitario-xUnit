using Calculadora.Services;

namespace ValidacoesStringTestes;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoesString;

    public ValidacoesStringTests()
    {
        _validacoesString = new ValidacoesString();
    }

    [Fact]
    public void DeveContar4CaracteresEmGutoERetornar4()
    {
        // Arange
       string texto = "Guto";

        // Act
        int result = _validacoesString.ContarCaracteres(texto);

        // Assert
        Assert.Equal(4, result);
    }
}