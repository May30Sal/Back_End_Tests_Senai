global using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tester.Core;
namespace Tester.MSTest
{
    // Testes Unit�rios MSTest
    [TestClass]
    public class OperacoesTests
    {
        // m�todo de teste
        [TestMethod]

        // descricao do teste
        public void SomarDoisNumeros()
        {
            // arrange � prepara��o do teste
            double primeiroNumero = 10;
            double segundoNumero = 20;
            double total = 30;

            // act � execu��o do m�todo
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            // Assert � comportamento esperado
            Assert.AreEqual(total, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 5)]
        public void SomarDoisNumerosLista(double primeiroNumero, double segundoNumero, double total)
        {
            //Act
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert
            Assert.AreEqual(total, resultado);
        }
    }
}