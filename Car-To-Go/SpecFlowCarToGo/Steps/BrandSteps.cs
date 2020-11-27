using System;
using Car_To_Go.Models;
using Car_To_Go.DomainService;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCarToGo.Steps
{
    [Binding]
    public sealed class BrandSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Brand _brand = new Brand();
        private string _resultado;
        int id;
        public BrandSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"ingresar la marca null")]
        public void GivenIngresarLaMarcaNull()
        {
            _brand = null;
        }
        [When(@"actualizar la marca")]
        public void WhenActualizarLaMarca()
        {
            var brandDomainService = new BrandDomainService();
            _resultado = brandDomainService.PutBrandDomainService(id, _brand);
        }
    

        [When(@"eliminar la marca")]
        public void WhenEliminarLaMarca()
        {
            var brandDomainService = new BrandDomainService();
            _resultado = brandDomainService.DeleteBrandDomainService(id, _brand);
        }

        [When(@"busca la marca")]
        public void WhenBuscaLaMarca()
        {
            var brandDomainService = new BrandDomainService();
             _resultado = brandDomainService.GetBrandDomainService(id, _brand);   
            _resultado = brandDomainService.DeleteBrandDomainService(id,_brand);
        }

        [Then(@"el resultado debe ser ""(.*)""")]
        public void ThenElResultadoDebeSer(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }
    }
}
