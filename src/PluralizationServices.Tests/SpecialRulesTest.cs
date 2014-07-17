using Xunit;

namespace PluralizationServices.Tests
{
    [Trait("Regras especiais", "Plural e singular")]
    public class SpecialRulesTest
    {
        private readonly PortuguesePluralizationService _service;

        public SpecialRulesTest()
        {
            _service = new PortuguesePluralizationService();
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em r")]
        public void PluralDeSubstantivoTerminadoEmR()
        {
            var plural = _service.Pluralize("par");

            Assert.Equal("pares", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em z")]
        public void PluralDeSubstantivoTerminadoEmZ()
        {
            var plural = _service.Pluralize("paiz");

            Assert.Equal("paizes", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em n")]
        public void PLuralDeSubstantivoTerminadoEmN()
        {
            var plural = _service.Pluralize("cânon");

            Assert.Equal("cânones", plural);
        }

        [Fact(DisplayName = "Singular de um substantivo terminando em r")]
        public void SingularDeSubstantivoTerminadoEmR() 
        {
            var plural = _service.Singularize("pares");

            Assert.Equal("par", plural);
        }

        [Fact(DisplayName = "Singular de um substantivo terminando em z")]
        public void SingularDeSubstantivoTerminadoEmZ() 
        {
            var plural = _service.Singularize("paizes");

            Assert.Equal("paiz", plural);
        }

        [Fact(DisplayName = "Singular de um substantivo terminando em n")]
        public void SingularDeSubstantivoTerminadoEmN() 
        {
            var plural = _service.Singularize("cânones");

            Assert.Equal("cânon", plural);
        }
    }
}