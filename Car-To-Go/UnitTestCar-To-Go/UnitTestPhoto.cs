using Car_To_Go.Models;
using Car_To_Go.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCar_To_Go
{
    [TestClass]
    public class UnitTestPhoto
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaFoto()
        {
            // Arrange
            var photo = new Photo();
            var id = new int();
            photo = null;
            // Act
            var photoDomainService = new PhotoDomainService();
            var resultado = photoDomainService.GetPhotoDomainService(id, photo);

            // Assert
            Assert.AreEqual("No se encontraron las Fotografias", resultado);
        }
    }
}
