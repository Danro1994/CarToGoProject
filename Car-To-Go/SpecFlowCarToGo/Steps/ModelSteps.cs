using System;
using Car_To_Go.Models;
using Car_To_Go.DomainService;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCarToGo.Steps
{
    [Binding]
    public sealed class ModelSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Model _model;
        private Brand _brand; 
        private Purchase _purchase;
        private string _resultado;
        int id;
        public ModelSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"ingresar el modelo null")]
        public void GivenIngresarElModeloNull()
        {
            _model = null;
        }
        [Given(@"ingresar en el modelo la marca null")]
        public void GivenIngresarEnElModeloLaMarcaNull()
        {
            _brand = null;
        }
        [Given(@"ingresar marca vacia")]
        public void GivenIngresarMarcaVacia()
        {
            _brand = null;
        }

        [When(@"postear el modelo")]
        public void WhenPostearElModelo()
        {
            _model = new Model();
            _purchase = new Purchase(_model, _brand);
            var modelDomainService = new ModelDomainService();
            _resultado = modelDomainService.PostModelDomainService(_purchase);
        }

        [When(@"actualizar la marca null")]
        public void WhenActualizarLaMarcaNull()
        {
            _model = new Model();
            _purchase = new Purchase(_model, _brand);
            var modelDomainService = new ModelDomainService();
            _resultado = modelDomainService.PutModelDomainService(id, _purchase);
        }

        [When(@"buscar el modelo")]
        public void WhenBuscarElModelo()
        {
            var modelDomainService = new ModelDomainService();
            _resultado = modelDomainService.GetModelDomainService(id, _model);
        }
        [When(@"actualizar el modelo")]
        public void WhenActualizarElModelo()
        {
            _brand=new Brand();
            _model = null;
            _purchase = new Purchase(_model, _brand);
            var modelDomainService = new ModelDomainService();
            _resultado = modelDomainService.PutModelDomainService(id, _purchase);
        }

        [When(@"eliminar el modelo")]
        public void WhenEliminarElModelo()
        {
            var modelDomainService = new ModelDomainService();
            _resultado = modelDomainService.DeleteModelDomainService(id, _model);
        }

        [Then(@"muestra el modelo ""(.*)""")]
        public void ThenMuestraElModelo(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }
    }
}
