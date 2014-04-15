using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PluralizationServices.Tests
{
    [Trait("Regras básicas","Plural e singular")]
    public class BasicRulesTest
    {
        [Fact(DisplayName = "Plural de um substantivo terminando em uma vogal")]
        public void PluralDeSubstantivoTerminadoEmVogal()
        {
            var service = new PortuguesePluralizationService();
            var plural = service.Pluralize("produto");

            Assert.Equal("produtos", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ã")]
        public void PluralDeSubstantivoTerminadoEmATio()
        {
            var service = new PortuguesePluralizationService();
            var plural = service.Pluralize("irmã");

            Assert.Equal("irmãs",plural);

        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ditongo oral")]
        public void PluralDeSubstantivoTerminadoEmDitongoOral()
        {
            var service = new PortuguesePluralizationService();
            var plural = service.Pluralize("troféu");

            Assert.Equal("troféus", plural);

        }

        [Fact(DisplayName = "Plural de nome de letras")]
        public void PluralDeNomeDeLetras()
        {
            var service = new PortuguesePluralizationService();
            var plural = service.Pluralize("efe");

            Assert.Equal("efes", plural);

        }

        [Fact(DisplayName = "Plural de nome de números")]
        public void PluralDeNomeDeNumeros()
        {
            var service = new PortuguesePluralizationService();
            var plural = service.Pluralize("quatro");

            Assert.Equal("quatros", plural);

        }
    }
}
