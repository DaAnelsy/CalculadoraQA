using CalculadoraApp;
namespace PruebaCalculadora
{
    [TestClass]
    public class PruebaCalculadora
    {
        [TestMethod]
        public void Suma2Numeros()
        {
            Calculadora miCalc = new Calculadora();
            Assert.IsTrue(miCalc.Sumar(5, 10) == 15);
        }
        [TestMethod]
        public void Restar2Numeros()
        {
            Calculadora miCalc = new Calculadora();
            Assert.IsTrue(miCalc.Restar(10, 5) == 5);
        }
        [TestMethod]
        public void Multiplicar2Numeros()
        {
            Calculadora miCalc = new Calculadora();
            Assert.IsTrue(miCalc.Multiplicar(5, 10) == 50);
        }
        [TestMethod]
        public void Dividir2Numeros()
        {
            Calculadora miCalc = new Calculadora();
            Assert.IsTrue(miCalc.Divide(10, 5) == 2);
        }

    }
}