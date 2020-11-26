using Car_To_Go.Models;
using Car_To_Go.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCar_To_Go
{
    [TestClass]
    public class UnitTestCondition
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCondicion()
        {
            // Arrange
            var condition = new Condition();
            var id = new int();
            condition = null;
            // Act
            var conditionDomainService = new ConditionDomainService();
            var resultado = conditionDomainService.GetConditionDomainService(id, condition);

            // Assert
            Assert.AreEqual("No se encontro la Condicion", resultado);
        }
    }
}
