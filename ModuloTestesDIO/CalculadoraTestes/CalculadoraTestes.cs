using System.Reflection.Metadata;
using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10Retornar15()
    {
        // Arange -> prepara o cenario
        int num1 = 5;
        int num2 = 10;
        
        // Act -> chama o cenario e executar
        int resultado = _calc.Somar(num1, num2);

        // Assert -> verifica se o resultado é igual ao esperado.
        Assert.Equal(15,resultado);


    }

    [Fact]
    public void DeveSubtrair15Com5Retornar10()
    {
        // Arange -> prepara o cenario
        int num1 = 15;
        int num2 = 5;
        
        // Act -> chama o cenario e executar
        int resultado = _calc.Subtrair(num1, num2);

        // Assert -> verifica se o resultado ou igaul ao esperado.
        Assert.Equal(10,resultado);


    }

    [Fact]

    public void DeveVerificarSeEhParRetornarVerdadeiro()
    {
        // Arange -> prepara o cenario
        int numero = 4;
        
        // Act -> chama o cenario e executar
        bool resultado = _calc.EhPar(numero);

        // Assert -> verifica se o resultado ou igaul ao esperado.

        Assert.True(resultado);
    }


 [Theory]
 [InlineData(2)]
 [InlineData(4)]
 [InlineData(6)]
 [InlineData(8)]
 [InlineData(10)]
 public void DeveVerificarSeOsNumerosSaoParRetornarVerdadeiro(int numero)
 {
       
   
    // Act -> chama o cenario e executar
    bool resultado = _calc.EhPar(numero);

    // Assert -> verifica se o resultado ou igaul ao esperado.
    Assert.True(resultado);

    
 }


 //fazendo com array
 [Theory]
 [InlineData(new int[] { 2, 4 })]
 [InlineData(new int[] { 6, 8, 10 })]

 public void DeveVerificarSeOsNumerosSaoParRetornarVerdadeiros(int[] numeros)
 {
       
   
    // Act -> chama o cenario e executar // Assert -> verifica se o resultado ou igaul ao esperado.
    //  foreach (var item in numero)
    //  {
    //     Assert.True(_calc.EhPar(item));
    //  }

    Assert.All(numeros, x => Assert.True(_calc.EhPar(x)));

    
 }

}