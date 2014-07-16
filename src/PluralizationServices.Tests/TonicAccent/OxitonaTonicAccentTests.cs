using PluralizationServices.TonicAccent;
using Xunit;
using Xunit.Extensions;

namespace PluralizationServices.Tests.TonicAccent {

    [Trait("Acento tônico", "Oxítonas")]
    public class OxitonaTonicAccentTests
    {
        private readonly ITonicAccent _tonicAccent;

        public OxitonaTonicAccentTests()
        {
            _tonicAccent = new OxitonaTonicAccent();
        }

        [Theory(DisplayName = "Terminadas em á, â, é, ê, ó ou ô")]
        [InlineData("cajá")]
        [InlineData("você")]
        [InlineData("dominó")]
        public void TerminadoEmAEO(string word)
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas em á, â, é, ê, ó ou ô com s")]
        [InlineData("cajás")]
        [InlineData("jacarés")]
        [InlineData("avôs")]
        public void TerminadoEmAEOComS(string word)
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas em á, â, é, ê, ó ou ô seguidas de pronomes")]
        [InlineData("amá-la")]
        [InlineData("dizê-lo")]
        [InlineData("pô-los")]
        public void TerminadoEmAEOSeguidaDePronome(string word)
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas com ém ou éns")]
        [InlineData("alguém")]
        [InlineData("nenéns")]
        public void TerminadoComEmOuEns(string word)
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas em i, í, u ou ú")]
        [InlineData("aqui")]
        [InlineData("saí")]
        [InlineData("bambu")]
        [InlineData("baú")]
        public void TerminadoEmIU(string word) 
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas em i, í, u ou ú com s")]
        [InlineData("gurupis")]
        [InlineData("urubus")]
        [InlineData("baús")]
        public void TerminadoEmIUComS(string word) 
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas em i, í, u ou ú seguidas de pronomes")]
        [InlineData("feri-lo")]
        [InlineData("atribuí-lo")]
        public void TerminadoEmIUSeguidaDePronome(string word) 
        {
            Assert.True(_tonicAccent.Verify(word));
        }
    }
}
