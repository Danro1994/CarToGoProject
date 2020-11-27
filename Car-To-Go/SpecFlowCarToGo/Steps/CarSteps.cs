using System;
using Car_To_Go.Models;
using Car_To_Go.DomainService;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCarToGo.Steps
{
    [Binding]
    public sealed class CarSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Model _model;
        private Brand _brand;
        private Photo _photo;
        private Status _status;
        private Seller _seller;
        private Condition _condition;
        private Car _car;
        private string _resultado;
        int id;
        public CarSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"ingresar el carro null")]
        public void GivenIngresarElCarroNull()
        {
            _car = null;
        }
        [Given(@"ingresar el carro con modelo vacio")]
        public void GivenIngresarElCarroConModeloVacio()
        {
            _model = null;
        }
        [Given(@"ingresar el carro sin fotografias")]
        public void GivenIngresarElCarroSinFotografias()
        {
            _photo = null;
        }
        [Given(@"ingresar el carro sin estado")]
        public void GivenIngresarElCarroSinEstado()
        {
            _status = null;
        }
        [Given(@"ingresar el carro sin vendedor")]
        public void GivenIngresarElCarroSinVendedor()
        {
            _seller = null;
        }
        [Given(@"ingresar el carro sin condicion")]
        public void GivenIngresarElCarroSinCondicion()
        {
            _condition = null;
        }
        [Given(@"ingresar el carro con anio (.*)")]
        public void GivenIngresarElCarroConAnio(int anio)
        {
          _car = new Car();
          _car.Year = anio;
        }
        [Given(@"actualizar cuando el carro no existe")]
        public void GivenActualizarCuandoElCarroNoExiste()
        {
            _car = null;
        }
        [Given(@"actualizar modelo del carro")]
        public void GivenActualizarModeloDelCarro()
        {
            _model = null;
        }
        [Given(@"un carro sin fotografias")]
        public void GivenUnCarroSinFotografias()
        {
            _photo = null;
        }
        [Given(@"un carro sin estado")]
        public void GivenUnCarroSinEstado()
        {
            _status = null;
        }
        [Given(@"un carro sin vendedor")]
        public void GivenUnCarroSinVendedor()
        {
            _seller = null;
        }
        [Given(@"un carro sin condicion")]
        public void GivenUnCarroSinCondicion()
        {
            _condition = null;
        }
        [Given(@"actualizar el carro con anio (.*)")]
        public void GivenActualizarElCarroConAnio(int anio)
        {
            _car = new Car();
            _car.Year = anio;
        }

        [When(@"actualizar con anio inferior")]
        public void WhenActualizarConAnioInferior()
        {
            _brand = new Brand();
            _condition = new Condition();
            _model = new Model();
            _photo = new Photo();
            _status = new Status();
            _seller = new Seller();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PutCarDomainService(id, purchase);
        }

        [When(@"actualizar carro sin condicion")]
        public void WhenActualizarCarroSinCondicion()
        {
            _brand = new Brand();
            _car = new Car();
            _model = new Model();
            _photo = new Photo();
            _status = new Status();
            _seller = new Seller();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PutCarDomainService(id, purchase);
        }


        [When(@"actualizar carro sin vendedor")]
        public void WhenActualizarCarroSinVendedor()
        {
            _brand = new Brand();
            _car = new Car();
            _model = new Model();
            _photo = new Photo();
            _status = new Status();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PutCarDomainService(id, purchase);
        }

        [When(@"actualizar carro sin estado")]
        public void WhenActualizarCarroSinEstado()
        {
            _brand = new Brand();
            _car = new Car();
            _model = new Model();
            _photo = new Photo();
            _seller = new Seller();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PutCarDomainService(id, purchase);
        }

        [When(@"actualizar carro sin fotografias")]
        public void WhenActualizarCarroSinFotografias()
        {
            _brand = new Brand();
            _car = new Car();
            _model = new Model();
            _status = new Status();
            _seller = new Seller();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PutCarDomainService(id, purchase);
        }

        [When(@"actualizar el modelo no encontrado")]
        public void WhenActualizarElModeloNoEncontrado()
        {
            _brand = new Brand();
            _car = new Car();
            _photo = new Photo();
            _status = new Status();
            _seller = new Seller();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PutCarDomainService(id, purchase);
        }

        [When(@"actualizar el carro")]
        public void WhenActualizarElCarro()
        {
            _brand = new Brand();
            _model = new Model();
            _photo = new Photo();
            _status = new Status();
            _seller = new Seller();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PutCarDomainService(id,purchase);
        }

        [When(@"postear con anio inferior")]
        public void WhenPostearConAnioInferior()
        {
            _brand = new Brand();
            _model = new Model();
            _photo = new Photo();
            _status = new Status();
            _seller = new Seller();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PostCarDomainService(purchase);
        }

        [When(@"postear el carro sin condicion")]
        public void WhenPostearElCarroSinCondicion()
        {
            _brand = new Brand();
            _car = new Car();
            _model = new Model();
            _photo = new Photo();
            _status = new Status();
            _seller = new Seller();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PostCarDomainService(purchase);
        }

        [When(@"postear el carro sin vendedor")]
        public void WhenPostearElCarroSinVendedor()
        {
            _brand = new Brand();
            _car = new Car();
            _model = new Model();
            _photo = new Photo();
            _status = new Status();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PostCarDomainService(purchase);
        }

        [When(@"postear el carro sin estado")]
        public void WhenPostearElCarroSinEstado()
        {
            _brand = new Brand();
            _car = new Car();
            _model = new Model();
            _photo = new Photo();
            _seller = new Seller();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PostCarDomainService(purchase);
        }

        [When(@"postear el carro sin fotografias")]
        public void WhenPostearElCarroSinFotografias()
        {
            _brand = new Brand();
            _car = new Car();
            _model = new Model();
            _status = new Status();
            _seller = new Seller();
            _condition = new Condition();

            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PostCarDomainService(purchase);
        }

        [When(@"postear el carro con modelo vacio")]
        public void WhenPostearElCarroConModeloVacio()
        {
            _brand = new Brand();
            _car = new Car();
            _photo = new Photo();
            _status = new Status();
            _seller = new Seller();
            _condition = new Condition();
           
            var purchase = new Purchase(_car, _model, _photo, _status, _seller, _condition);
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.PostCarDomainService(purchase);
        }

        [When(@"buscar el carro")]
        public void WhenBuscarElCarro()
        {
            _car = new Car();
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.GetCarDomainService(_car);
        }
        [When(@"eliminar el carro")]
        public void WhenEliminarElCarro()
        {
            var carDomainService = new CarDomainService();
            _resultado = carDomainService.DeleteCarDomainService(id,_car);
        }

        [Then(@"debe mostrar ""(.*)""")]
        public void ThenDebeMostrar(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }
    }
}
