using Car_To_Go.Models;
using Car_To_Go.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCar_To_Go
{
    [TestClass]
    public class UnitTestStatus
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnEstado()
        {
            // Arrange
            var status = new Status();
            var id = new int();
            status = null;
            // Act
            var statusDomainService = new StatusDomainService();
            var resultado = statusDomainService.GetStatusDomainService(id, status);

            // Assert
            Assert.AreEqual("No se encontro este Estado", resultado);
        }
    }
}
