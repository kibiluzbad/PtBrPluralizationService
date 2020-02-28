namespace PluralizationServices.Tests.Rules
{
    using FluentAssertions;

    using Xunit;

    [Trait("Regras básicas", "Plural e singular")]
    public sealed class BasicRulesTest
    {
        private readonly PortuguesePluralizationService service;

        public BasicRulesTest() => this.service = new PortuguesePluralizationService();

        [Fact(DisplayName = "Plural de um substantivo terminando em uma vogal")]
        public void PluralDeSubstantivoTerminadoEmVogal() => this.service.Pluralize("produto").Should().Be("produtos");

        [Fact(DisplayName = "Plural de um substantivo terminando em ã")]
        public void PluralDeSubstantivoTerminadoEmATio() => this.service.Pluralize("irmã").Should().Be("irmãs");

        [Fact(DisplayName = "Plural de um substantivo terminando em ditongo oral")]
        public void PluralDeSubstantivoTerminadoEmDitongoOral() => this.service.Pluralize("troféu").Should().Be("troféus");

        [Fact(DisplayName = "Plural de nome de letras")]
        public void PluralDeNomeDeLetras() => this.service.Pluralize("efe").Should().Be("efes");

        [Fact(DisplayName = "Plural de nome de números")]
        public void PluralDeNomeDeNumeros() => this.service.Pluralize("quatro").Should().Be("quatros");

        [Fact(DisplayName = "Singular de um susbstantivo terminado em vogal")]
        public void SingularDeSubstantivoTerminadoEmVogal() => this.service.Singularize("produtos").Should().Be("produto");

        [Fact(DisplayName = "Singular de um substantivo terminando em ã")]
        public void SingularDeSubstantivoTerminadoEmATio() => this.service.Singularize("irmãs").Should().Be("irmã");

        [Fact(DisplayName = "Singular de um substantivo terminando em ditongo oral")]
        public void SingularDeSubstantivoTerminadoEmDitongoOral() => this.service.Singularize("troféus").Should().Be("troféu");

        [Fact(DisplayName = "Singular de nome de letras")]
        public void SingularDeNomeDeLetras() => this.service.Singularize("efes").Should().Be("efe");

        [Fact(DisplayName = "Singular de nome de números")]
        public void SingularDeNomeDeNumeros() => this.service.Singularize("quatros").Should().Be("quatro");
    }
}
