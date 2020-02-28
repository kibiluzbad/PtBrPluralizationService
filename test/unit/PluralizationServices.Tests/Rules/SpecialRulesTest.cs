namespace PluralizationServices.Tests.Rules
{
    using FluentAssertions;

    using Xunit;

    [Trait("Regras especiais", "Plural e singular")]
    public sealed class SpecialRulesTest
    {
        private readonly PortuguesePluralizationService service;

        public SpecialRulesTest() => this.service = new PortuguesePluralizationService();

        [Fact(DisplayName = "Plural de um substantivo terminando em r")]
        public void PluralDeSubstantivoTerminadoEmR() => this.service.Pluralize("par").Should().Be("pares");

        [Fact(DisplayName = "Plural de um substantivo terminando em z")]
        public void PluralDeSubstantivoTerminadoEmZ() => this.service.Pluralize("paiz").Should().Be("paizes");

        [Fact(DisplayName = "Plural de um substantivo terminando em n")]
        public void PluralDeSubstantivoTerminadoEmN() => this.service.Pluralize("cânon").Should().Be("cânones");

        [Fact(DisplayName = "Singular de um substantivo terminando em r")]
        public void SingularDeSubstantivoTerminadoEmR() => this.service.Singularize("pares").Should().Be("par");

        [Fact(DisplayName = "Singular de um substantivo terminando em z")]
        public void SingularDeSubstantivoTerminadoEmZ() => this.service.Singularize("paizes").Should().Be("paiz");

        [Fact(DisplayName = "Singular de um substantivo terminando em n")]
        public void SingularDeSubstantivoTerminadoEmN() => this.service.Singularize("cânones").Should().Be("cânon");
    }
}
