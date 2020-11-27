using System;
using Car_To_Go.Models;
using Car_To_Go.DomainService;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCarToGo.Steps
{
    [Binding]
    public sealed class PhotoSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Photo _photo = new Photo();
        private string _resultado;
        int id;
        public PhotoSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"ingresar la fotografia null")]
        public void GivenIngresarLaFotografiaNull()
        {
            _photo=null;
        }
        [Given(@"postear la fotografia null")]
        public void GivenPostearLaFotografiaNull()
        {
            _photo = null;
        }

        [When(@"ingresar la fotografia")]
        public void WhenIngresarLaFotografia()
        {
            var photoDomainService = new PhotoDomainService();
            _resultado = photoDomainService.PutPhotoDomainService(id,_photo);
        }

        [Then(@"devuelve ""(.*)""")]
        public void ThenDevuelve(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }

        [When(@"buscar la fotografia")]
        public void WhenBuscarLaFotografia()
        {
            var photoDomainService = new PhotoDomainService();
            _resultado = photoDomainService.GetPhotoDomainService(id, _photo);
        }
        [When(@"eliminar la fotografia")]
        public void WhenEliminarLaFotografia()
        {
            var photoDomainService = new PhotoDomainService();
            _resultado = photoDomainService.DeletePhotoDomainService(id, _photo);
        }

        [Then(@"lo que muestra ""(.*)""")]
        public void ThenLoQueMuestra(string respuesta)
        {
            _resultado.Should().Be(respuesta);
        }
    }
}
