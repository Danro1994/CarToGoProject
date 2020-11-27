using Car_To_Go.DomainService;
using Car_To_Go.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCar_To_Go
{
    [TestClass]
    public class UnitTestCar
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCarro()
        {
            // Arrange
            var car = new Car();
            var id = new int();
            car = null;
         //   var purchase = new Purchase(model, brand);

            // Act
            var carDomainService= new CarDomainService();
            var resultado = carDomainService.GetCarDomainService(car);

            // Assert
            Assert.AreEqual("No se Encontro el Vehiculo", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnModelo()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo= new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            model = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PostCarDomainService(purchase);

            // Assert
            Assert.AreEqual("El Modelo no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaPhoto()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            photo = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PostCarDomainService(purchase);

            // Assert
            Assert.AreEqual("Estas fotografias no estan registradas", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnStatus()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            status = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PostCarDomainService(purchase);

            // Assert
            Assert.AreEqual("El Estado no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnVendedor()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            seller = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PostCarDomainService(purchase);

            // Assert
            Assert.AreEqual("El Vendedor no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCondicion()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            condition = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PostCarDomainService(purchase);

            // Assert
            Assert.AreEqual("La Condicion no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnAñodelCarro ()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            car.Year = 1990;
            var purchase = new Purchase(car, model, photo, status, seller, condition);
            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PostCarDomainService(purchase);

            // Assert
            Assert.AreEqual("El vehiculo debe ser año 1990 en adelante", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCarro2()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            car = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PutCarDomainService(id, purchase);

            // Assert
            Assert.AreEqual("No se encuentra el Vehiculo", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnModelo2()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            model = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PutCarDomainService(id, purchase);

            // Assert
            Assert.AreEqual("El Modelo no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaPhoto2()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            photo = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PutCarDomainService(id,purchase);

            // Assert
            Assert.AreEqual("Estas fotografias no estan registradas", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnStatus2()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            status = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PutCarDomainService(id,purchase);

            // Assert
            Assert.AreEqual("El Estado no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnVendedor2()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            seller = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PutCarDomainService(id,purchase);

            // Assert
            Assert.AreEqual("El Vendedor no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCondicion2()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            condition = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PutCarDomainService(id, purchase);

            // Assert
            Assert.AreEqual("La Condicion no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnAñodelCarro2()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            car.Year = 1990;
            var purchase = new Purchase(car, model, photo, status, seller, condition);
            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.PutCarDomainService(id, purchase);

            // Assert
            Assert.AreEqual("El vehiculo debe ser año 1990 en adelante", resultado);
        }
        [TestMethod]

        public void PruebaParaValidarQueSeEncuentraUnCarro3()
        {
            // Arrange
            var model = new Model();
            var brand = new Brand();
            var car = new Car();
            var photo = new Photo();
            var status = new Status();
            var seller = new Seller();
            var condition = new Condition();
            var id = new int();
            car = null;
            var purchase = new Purchase(car, model, photo, status, seller, condition);

            // Act
            var carDomainService = new CarDomainService();
            var resultado = carDomainService.DeleteCarDomainService(id, car);

            // Assert
            Assert.AreEqual("No se encuentra el Vehiculo", resultado);
        }
    }
}
