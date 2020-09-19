using NUnit.Framework;
using ParcialMaelyZambrana.Controllers;

namespace UnitTestParcial1
{
    public class Tests
    {
        [TestMethod]
        public void TestGetParcial1()
        {
            //Arrange
            Parcial1Controller parcia1Controller = new Parcial1Controller();

            //Act
            var listaPrueba = parcia1Controller.GetParcial1();

            //Assert
            Assert.IsNotNull(listaPrueba);
        }
    }
}