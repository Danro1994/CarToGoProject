using System;
using Car_To_Go.Models;
using Car_To_Go.DomainService;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCarToGo.Steps
{
    [Binding]
    public sealed class ConditionSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Condition _condition = new Condition();
        private string _resultado;
        int id;
        public ConditionSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"ingresar la condicion null")]
        public void GivenIngresarLaCondicionNull()
        {
            _condition = null;
        }
        
        [When(@"busca la condicion")]
        public void WhenBuscaLaCondicion()
        {
            var conditionDomainService = new ConditionDomainService();
            _resultado = conditionDomainService.GetConditionDomainService(id, _condition);
        }
        [When(@"actualizar la condicion")]
        public void WhenActualizarLaCondicion()
        {
            var conditionDomainService = new ConditionDomainService();
            _resultado = conditionDomainService.PutConditionDomainService(id, _condition);
        }

        [When(@"eliminar la condicion")]
        public void WhenEliminarLaCondicion()
        {
            var conditionDomainService = new ConditionDomainService();
            _resultado = conditionDomainService.DeleteConditionDomainService(id, _condition);
        }

        [Then(@"la respuesta es ""(.*)""")]
        public void ThenLaRespuestoEs(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }
    }
}
