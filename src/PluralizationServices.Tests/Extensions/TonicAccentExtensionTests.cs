using PluralizationServices.Extensions;
using Xunit;

namespace PluralizationServices.Tests.Extensions
{
    [Trait("Acento tônico", "Oxítonas, paroxítonas e proparoxítonas")]
    public class TonicAccentExtensionTests
    {
        [Fact(DisplayName = "Oxítonas ou agudas")]
        public void OxitonasOuAgudas()
        {
            const string word = "você";

            Assert.True(word.IsOxitona());
        }
    }
}