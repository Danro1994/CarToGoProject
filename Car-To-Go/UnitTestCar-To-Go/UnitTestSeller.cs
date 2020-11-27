using Car_To_Go.Models;
using Car_To_Go.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCar_To_Go
{
    [TestClass]
    public class UnitTestSeller
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnVendedor()
        {
            // Arrange
            var seller = new Seller();
            var id = new int();
            seller = null;
            // Act
            var sellerDomainService = new SellerDomainService();
            var resultado = sellerDomainService.GetSellerDomainService(id, seller);

            // Assert
            Assert.AreEqual("No se encontro el Vendedor", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnVendedor2()
        {
            // Arrange
            var seller = new Seller();
            var id = new int();
            seller = null;
            // Act
            var sellerDomainService = new SellerDomainService();
            var resultado = sellerDomainService.PutSellerDomainService(id, seller);

            // Assert
            Assert.AreEqual("No se encontro el Vendedor", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnVendedor3()
        {
            // Arrange
            var seller = new Seller();
            var id = new int();
            seller = null;
            // Act
            var sellerDomainService = new SellerDomainService();
            var resultado = sellerDomainService.DeleteSellerDomainService(id, seller);

            // Assert
            Assert.AreEqual("No se encontro el Vendedor", resultado);
        }
    }
}
