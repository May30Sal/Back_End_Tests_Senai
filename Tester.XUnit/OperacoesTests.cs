global using Xunit;
using Tester.Core;
namespace Tester.XUnit
{
    public class OperacoesTests
    {
        // Testes Unit�rios XUnit
        [Fact]

        // descricao do teste
        public void SomarDoisNumeros()
        {
            // arrange � organiza��o do teste
            double primeiroNumero = 10;
            double segundoNumero = 20;
            double total = 30;

            // act � execu��o do m�todo
            var resultado = Operacoes.Somar(primeiroNumero,
            segundoNumero);

            // Assert � comportamento esperado
            Assert.Equal(total, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 6)]
        public void SomarDoisNumerosLista(double primeiroNumero, double segundoNumero, double total)
        {
            //Act
            var resultadoSoma = Operacoes.Somar(primeiroNumero,
            segundoNumero);

            //Assert
            Assert.Equal(total, resultadoSoma);
        }
    }
}