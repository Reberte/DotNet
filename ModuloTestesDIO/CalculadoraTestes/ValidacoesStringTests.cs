using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }


        [Fact]

        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange -> Preparando o cenario para o teste, os dados de entrada
            string texto = "Olá";

            // Act -> Chama o cenario e executa, coloca o resultado na variavel
            int resultado = _validacoes.ContarCaracteres(texto);


            // Assert -> Verifica se o cenario trouxe o resultado esperado

            Assert.Equal(3, resultado);
        }
    }
}