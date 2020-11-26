using Car_To_Go.Models;
using Car_To_Go.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCar_To_Go
{
    [TestClass]
    public class UnitTestBrand
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaMarca()
        {
            // Arrange
            var brand = new Brand();
            var id = new int();
            brand = null;
            // Act
            var brandDomainService = new BrandDomainService();
            var resultado = brandDomainService.GetBrandDomainService(id, brand);

            // Assert
            Assert.AreEqual("No se encontro la Marca", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaMarca2()
        {
            // Arrange
            var brand = new Brand();
            var id = new int();
            brand = null;
            // Act
            var brandDomainService = new BrandDomainService();
            var resultado = brandDomainService.PutBrandDomainService(id, brand);

            // Assert
            Assert.AreEqual("No se encontro la Marca", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaMarca3()
        {
            // Arrange
            var brand = new Brand();
            var id = new int();
            brand = null;
            // Act
            var brandDomainService = new BrandDomainService();
            var resultado = brandDomainService.DeleteBrandDomainService(id, brand);

            // Assert
            Assert.AreEqual("No se encontro la Marca", resultado);
        }
    }
}
