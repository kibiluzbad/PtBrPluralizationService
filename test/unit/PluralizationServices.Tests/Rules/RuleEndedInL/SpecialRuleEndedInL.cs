namespace PluralizationServices.Tests.Rules.RuleEndedInL
{
    using FluentAssertions;

    using Xunit;

    [Trait("Regras especiais terminando em l", "Plural e singular")]
    public sealed class SpecialRuleEndedInL
    {
        private readonly PortuguesePluralizationService service;

        public SpecialRuleEndedInL() => this.service = new PortuguesePluralizationService();

        [Fact(DisplayName = "Plural de um substantivo terminando em al")]
        public void PluralDeSubstantivoTerminadoEmAl() => this.service.Pluralize("funeral").Should().Be("funerais");

        [Fact(DisplayName = "Plural de um substantivo terminando em al exceção mal")]
        public void PluralDeSubstantivoTerminadoEmAlExceptionMal() => this.service.Pluralize("mal").Should().Be("males");

        [Fact(DisplayName = "Plural de um substantivo terminando em al exceção real")]
        public void PluralDeSubstantivoTerminadoEmAlExceptionReal() => this.service.Pluralize("real").Should().Be("réis");

        [Fact(DisplayName = "Plural de um substantivo terminando em el")]
        public void PluralDeSubstantivoTerminadoEmEl() => this.service.Pluralize("pastel").Should().Be("pastéis");

        [Fact(DisplayName = "Plural de um substantivo terminando em il")]
        public void PluralDeSubstantivoTerminadoEmIl() => this.service.Pluralize("canil").Should().Be("canis");

        [Fact(DisplayName = "Plural de um substantivo terminando em il átono")]
        public void PluralDeSubstantivoTerminadoEmIlAtono() => this.service.Pluralize("fóssil").Should().Be("fósseis");

        [Fact(DisplayName = "Plural de um substantivo terminando em ol")]
        public void PluralDeSubstantivoTerminadoEmOl() => this.service.Pluralize("farol").Should().Be("faróis");

        [Fact(DisplayName = "Plural de um substantivo terminando em ul")]
        public void PluralDeSubstantivoTerminadoEmUl() => this.service.Pluralize("Raul").Should().Be("Rauis");

        [Fact(DisplayName = "Plural de um substantivo terminando em ul exceção cônsul")]
        public void PluralDeSubstantivoTerminadoEmUlExceptionConsul() => this.service.Pluralize("cônsul").Should().Be("cônsules");
    }
}
