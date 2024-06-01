using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(75, 25, 100)]
    [InlineData(65, 25, 90)]
    public void DeveSomarERetornar(int num1, int num2, int resultado)
    {

        int resultadoOperação = _calc.Somar(num1, num2);

        Assert.Equal(resultado, resultadoOperação);

    }

    [Theory]
    [InlineData(75, 25, 50)]
    [InlineData(65, 25, 40)]
    public void DeveSubtrairERetornar(int num1, int num2, int resultado)
    {
        
        int resultadoOperação = _calc.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadoOperação);

    }

    [Theory]
    [InlineData(75, 25, 1875)]
    [InlineData(65, 25, 1625)]
    public void DeveMultiplicarERetornar(int num1, int num2, int resultado)
    {
        
        int resultadoOperação = _calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoOperação);

    }

    [Theory]
    [InlineData(75, 25, 3)]
    [InlineData(60, 20, 3)] // voltar e resolver [inlineData(65, 25, 2.6)]
    public void DeveDividirERetornar(int num1, int num2, int resultado)
    {
        
        int resultadoOperação = _calc.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoOperação);

    }

    [Fact]
    public void DividirNumeroPor0()
    {
        
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(6,0));

    }

    [Fact]
    public void HistoricoDeOperação()
    {

        _calc.Somar(2, 2);
        _calc.Subtrair(2, 4);
        _calc.Multiplicar(7, 5);
        _calc.Dividir(10, 2);
        
        var lista = _calc.Historico();
        
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    
    }
}