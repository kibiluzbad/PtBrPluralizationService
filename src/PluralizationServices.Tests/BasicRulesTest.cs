using Xunit;

namespace PluralizationServices.Tests
{
    [Trait("Regras básicas", "Plural e singular")]
    public class BasicRulesTest
    {
        private readonly PortuguesePluralizationService _service;

        public BasicRulesTest()
        {
            _service = new PortuguesePluralizationService();
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em uma vogal")]
        public void PluralDeSubstantivoTerminadoEmVogal()
        {
            var plural = _service.Pluralize("produto");

            Assert.Equal("produtos", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ã")]
        public void PluralDeSubstantivoTerminadoEmATio()
        {
            var plural = _service.Pluralize("irmã");

            Assert.Equal("irmãs", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ditongo oral")]
        public void PluralDeSubstantivoTerminadoEmDitongoOral()
        {
            var plural = _service.Pluralize("troféu");

            Assert.Equal("troféus", plural);
        }

        [Fact(DisplayName = "Plural de nome de letras")]
        public void PluralDeNomeDeLetras()
        {
            var plural = _service.Pluralize("efe");

            Assert.Equal("efes", plural);
        }

        [Fact(DisplayName = "Plural de nome de números")]
        public void PluralDeNomeDeNumeros()
        {
            var plural = _service.Pluralize("quatro");

            Assert.Equal("quatros", plural);
        }

        [Fact(DisplayName = "Singular de um susbstantivo terminado em vogal")]
        public void SingularDeSubstantivoTerminadoEmVogal()
        {
            var service = new PortuguesePluralizationService();
            var singular = service.Singularize("produtos");

            Assert.Equal("produto", singular);
        }

        [Fact(DisplayName = "Singular de um substantivo terminando em ã")]
        public void SingularDeSubstantivoTerminadoEmATio()
        {
            var service = new PortuguesePluralizationService();
            var singular = service.Singularize("irmãs");

            Assert.Equal("irmã", singular);
        }

        [Fact(DisplayName = "Singular de um substantivo terminando em ditongo oral")]
        public void SingularDeSubstantivoTerminadoEmDitongoOral()
        {
            var service = new PortuguesePluralizationService();
            var singular = service.Singularize("troféus");

            Assert.Equal("troféu", singular);
        }

        [Fact(DisplayName = "Singular de nome de letras")]
        public void SingularDeNomeDeLetras()
        {
            var service = new PortuguesePluralizationService();
            var singular = service.Singularize("efes");

            Assert.Equal("efe", singular);
        }

        [Fact(DisplayName = "Singular de nome de números")]
        public void SingularDeNomeDeNumeros()
        {
            var service = new PortuguesePluralizationService();
            var singular = service.Singularize("quatros");

            Assert.Equal("quatro", singular);
        }
    }
}
