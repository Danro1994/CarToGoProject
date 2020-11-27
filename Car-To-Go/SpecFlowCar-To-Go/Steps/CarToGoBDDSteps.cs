using System;
using Car_To_Go.Models;
using Car_To_Go.DomainService;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCarToGo.Steps
{
    [Binding]
    public sealed class CarToGoBDDSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Brand _brand = new Brand();
        private string _resultado;
        int id;
        public CarToGoBDDSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"ingresar la marca null")]
        public void GivenIngresarLaMarcaNull()
        {
            _brand = null;
        }
        
        [When(@"busca la marca")]
        public void WhenBuscaLaMarca()
        {
            var brandDomainService = new BrandDomainService();
            var resultado = brandDomainService.GetBrandDomainService(id, _brand);
        }
        
        [Then(@"el resultado debe ser ""(.*)""")]
        public void ThenElResultadoDebeSer(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }
    }
}
