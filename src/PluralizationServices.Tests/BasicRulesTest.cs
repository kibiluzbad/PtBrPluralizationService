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
    }
}
