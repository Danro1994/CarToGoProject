using Car_To_Go.DomainService;
using Car_To_Go.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCar_To_Go
{
    [TestClass]
    public class UnitTestModel
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnModelo()
        {
            // Arrange
            var model = new Model();
            var id = new int();
            model = null;
            // Act
            var modelDomainService = new ModelDomainService();
            var resultado = modelDomainService.GetModelDomainService(id, model);

            // Assert
            Assert.AreEqual("No se encuentra el Modelo", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaBrand()
        {
            // Arrange
            var brand = new Brand();
            var model = new Model();
            var id = new int();
            brand = null;
            var purchase = new Purchase(model, brand);
            // Act
            var modelDomainService = new ModelDomainService();
            var resultado = modelDomainService.PostModelDomainService(purchase);

            // Assert
            Assert.AreEqual("No se encuentra la Marca", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnModelo2()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var id = new int();
            model = null;
            var purchase = new Purchase(model, brand);

            // Act
            var modelDomainService = new ModelDomainService();
            var resultado = modelDomainService.PutModelDomainService(id, purchase);

            // Assert
            Assert.AreEqual("No se encuentra el Modelo", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaBrand2()
        {
            // Arrange
            var brand = new Brand();
            var model = new Model();
            var id = new int();
            brand = null;
            var purchase = new Purchase(model, brand);
            // Act
            var modelDomainService = new ModelDomainService();
            var resultado = modelDomainService.PutModelDomainService(id, purchase);

            // Assert
            Assert.AreEqual("No se encuentra la Marca", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnModelo3()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var id = new int();
            model = null;
            var purchase = new Purchase(model, brand);

            // Act
            var modelDomainService = new ModelDomainService();
            var resultado = modelDomainService.DeleteModelDomainService(id, model);

            // Assert
            Assert.AreEqual("No se encuentra el Modelo", resultado);
        }
    }
}
