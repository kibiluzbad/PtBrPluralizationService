using Xunit;

namespace PluralizationServices.Tests.Rules.RuleEndedInL
{
    [Trait("Regras especiais terminando em l", "Plural e singular")]
    public class SpecialRuleEndedInL
    {
        private readonly PortuguesePluralizationService _service;

        public SpecialRuleEndedInL()
        {
            _service = new PortuguesePluralizationService();
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em al")]
        public void PLuralDeSubstantivoTerminadoEmAl() 
        {
            var plural = _service.Pluralize("funeral");

            Assert.Equal("funerais", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em al exceção mal")]
        public void PLuralDeSubstantivoTerminadoEmAlExceptionMal() 
        {
            var plural = _service.Pluralize("mal");

            Assert.Equal("males", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em al exceção real")]
        public void PLuralDeSubstantivoTerminadoEmAlExceptionReal() 
        {
            var plural = _service.Pluralize("real");

            Assert.Equal("réis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em el")]
        public void PLuralDeSubstantivoTerminadoEmEl() 
        {
            var plural = _service.Pluralize("pastel");

            Assert.Equal("pastéis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em il")]
        public void PLuralDeSubstantivoTerminadoEmIl() 
        {
            var plural = _service.Pluralize("canil");

            Assert.Equal("canis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em il átono")]
        public void PLuralDeSubstantivoTerminadoEmIlAtono() 
        {
            var plural = _service.Pluralize("fóssil");

            Assert.Equal("fósseis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ol")]
        public void PLuralDeSubstantivoTerminadoEmOl() 
        {
            var plural = _service.Pluralize("farol");

            Assert.Equal("faróis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ul")]
        public void PLuralDeSubstantivoTerminadoEmUl() 
        {
            var plural = _service.Pluralize("Raul");

            Assert.Equal("Rauis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ul exceção cônsul")]
        public void PLuralDeSubstantivoTerminadoEmUlExceptionConsul() 
        {
            var plural = _service.Pluralize("cônsul");

            Assert.Equal("cônsules", plural);
        }
    }
}