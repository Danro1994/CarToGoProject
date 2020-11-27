using System;
using Car_To_Go.Models;
using Car_To_Go.DomainService;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCarToGo.Steps
{
    [Binding]
    public sealed class StatusSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Status _status = new Status();
        private string _resultado;
        int id;
        public StatusSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"ingresar el estado null")]
        public void GivenIngresarElEstadoNull()
        {
            _status = null;
        }
        
        [When(@"buscar el estado")]
        public void WhenBuscarElEstado()
        {
            var statusDomainService = new StatusDomainService();
            _resultado = statusDomainService.GetStatusDomainService(id, _status);
        }
        [When(@"actualizar el estado")]
        public void WhenActualizarElEstado()
        {
            var statusDomainService = new StatusDomainService();
            _resultado = statusDomainService.PutStatusDomainService(id, _status);
        }
        [When(@"eliminar el estado")]
        public void WhenEliminarElEstado()
        {
            var statusDomainService = new StatusDomainService();
            _resultado = statusDomainService.DeleteStatusDomainService(id, _status);
        }

        [Then(@"muestra el estado ""(.*)""")]
        public void ThenMuestraElEstado(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }
    }
}
