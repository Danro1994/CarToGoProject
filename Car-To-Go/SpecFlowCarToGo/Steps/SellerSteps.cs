using System;
using Car_To_Go.Models;
using Car_To_Go.DomainService;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCarToGo.Steps
{
    [Binding]
    public sealed class SellerSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Seller _seller = new Seller();
        private string _resultado;
        int id;
        public SellerSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"ingresar el vendedor null")]
        public void GivenIngresarElVendedorNull()
        {
            _seller = null;
        }
        
        [When(@"buscar vendedor")]
        public void WhenBuscarVendedor()
        {
            var sellerDomainService = new SellerDomainService();
            _resultado = sellerDomainService.GetSellerDomainService(id, _seller);
        }
        [When(@"actualizar vendedor")]
        public void WhenActualizarVendedor()
        {
            var sellerDomainService = new SellerDomainService();
            _resultado = sellerDomainService.PutSellerDomainService(id, _seller);
        }

        [When(@"eliminar vendedor")]
        public void WhenEliminarVendedor()
        {
            var sellerDomainService = new SellerDomainService();
            _resultado = sellerDomainService.DeleteSellerDomainService(id, _seller);
        }

        [Then(@"lo que encuentra ""(.*)""")]
        public void ThenLoQueEncuentra(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }
    }
}
