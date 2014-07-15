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

        [Theory(DisplayName = "Terminadas em a, e ou o")]
        [InlineData("cajá")]
        [InlineData("você")]
        [InlineData("dominó")]
        public void TerminadoEmAEO(string word)
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas em a, e ou o com s")]
        [InlineData("cajás")]
        [InlineData("jacarés")]
        [InlineData("avôs")]
        public void TerminadoEmAEOComS(string word)
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas em a, e ou o seguidas de pronomes")]
        [InlineData("amá-la")]
        [InlineData("dizê-lo")]
        [InlineData("pô-los")]
        public void TerminadoEmAEOSeguidaDePronome(string word)
        {
            Assert.True(_tonicAccent.Verify(word));
        }

        [Theory(DisplayName = "Terminadas com em ou ens")]
        [InlineData("alguém")]
        [InlineData("nenéns")]
        public void TerminadoComEmOuEns(string word)
        {
            Assert.True(_tonicAccent.Verify(word));
        }
    }
}
