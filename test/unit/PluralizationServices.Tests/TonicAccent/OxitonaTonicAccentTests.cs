namespace PluralizationServices.Tests.TonicAccent
{
    using FluentAssertions;

    using PluralizationServices.TonicAccent;

    using Xunit;

    [Trait("Acento tônico", "Oxítonas")]
    public class OxitonaTonicAccentTests
    {
        private readonly ITonicAccent tonicAccent;

        public OxitonaTonicAccentTests() => this.tonicAccent = new OxitonaTonicAccent();

        [Theory(DisplayName = "Terminadas em á, â, é, ê, ó ou ô")]
        [InlineData("cajá")]
        [InlineData("você")]
        [InlineData("dominó")]
        public void TerminadoEmAEO(string word) => this.tonicAccent.Verify(word).Should().BeTrue();

        [Theory(DisplayName = "Terminadas em á, â, é, ê, ó ou ô com s")]
        [InlineData("cajás")]
        [InlineData("jacarés")]
        [InlineData("avôs")]
        public void TerminadoEmAEOComS(string word) => this.tonicAccent.Verify(word).Should().BeTrue();

        [Theory(DisplayName = "Terminadas em á, â, é, ê, ó ou ô seguidas de pronomes")]
        [InlineData("amá-la")]
        [InlineData("dizê-lo")]
        [InlineData("pô-los")]
        public void TerminadoEmAEOSeguidaDePronome(string word) => this.tonicAccent.Verify(word).Should().BeTrue();

        [Theory(DisplayName = "Terminadas com ém ou éns")]
        [InlineData("alguém")]
        [InlineData("nenéns")]
        public void TerminadoComEmOuEns(string word) => this.tonicAccent.Verify(word).Should().BeTrue();

        [Theory(DisplayName = "Terminadas em i, í, u ou ú")]
        [InlineData("aqui")]
        [InlineData("saí")]
        [InlineData("bambu")]
        [InlineData("baú")]
        public void TerminadoEmIU(string word) => this.tonicAccent.Verify(word).Should().BeTrue();

        [Theory(DisplayName = "Terminadas em i, í, u ou ú com s")]
        [InlineData("gurupis")]
        [InlineData("urubus")]
        [InlineData("baús")]
        public void TerminadoEmIUComS(string word) => this.tonicAccent.Verify(word).Should().BeTrue();

        [Theory(DisplayName = "Terminadas em i, í, u ou ú seguidas de pronomes")]
        [InlineData("feri-lo")]
        [InlineData("atribuí-lo")]
        public void TerminadoEmIUSeguidaDePronome(string word) => this.tonicAccent.Verify(word).Should().BeTrue();
    }
}
