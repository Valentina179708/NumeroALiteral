using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numero_a_Literal.Controllers;

namespace UnitTestLiteral
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral1()
        {
            //Arrange
            LiteralController objetoliteral = new LiteralController();
            int numero = 11;
            string esperado = "once";

            //Act
            string actual = objetoliteral.literal(numero);

            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void TestLiteral2()
        {
            //Arrange
            LiteralController objetoliteral = new LiteralController();
            int numero = 245678;
            string esperado = "doscientos cuarenta y cinco mil seiscientos setenta y ocho";

            //Act
            string actual = objetoliteral.literal(numero);

            //Assert
            Assert.AreEqual(esperado, actual);
        }
    }
}
