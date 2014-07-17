using PluralizationServices.Extensions;
using Xunit;
using Xunit.Extensions;

namespace PluralizationServices.Tests.Extensions
{
    [Trait("Fonema", "Vogal e consoante")]
    public class PhonemeExtensionTests
    {
        [Theory(DisplayName = "Vogal a, A, ã e Ã")]
        [InlineData('a')]
        [InlineData('A')]
        [InlineData('ã')]
        [InlineData('Ã')]
        public void VogalaA(char letter) 
        {
            Assert.True(letter.IsVowel());
        }

        [Theory(DisplayName = "Consoante b e B")]
        [InlineData('b')]
        [InlineData('B')]
        public void ConsoantebB(char letter) 
        {
            Assert.True(letter.IsConsonant());
        }
    }
}