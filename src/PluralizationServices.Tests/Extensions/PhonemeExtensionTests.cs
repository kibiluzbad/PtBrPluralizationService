using PluralizationServices.Extensions;
using Xunit;

namespace PluralizationServices.Tests.Extensions
{
    [Trait("Fonema", "Vogal e consoante")]
    public class PhonemeExtensionTests
    {
        [Fact(DisplayName = "Vogal a")]
        public void Vogala() 
        {
            const char letter = 'a';

            Assert.True(letter.IsVowel());
        }

        [Fact(DisplayName = "Vogal A")]
        public void VogalA() 
        {
            const char letter = 'A';

            Assert.True(letter.IsVowel());
        }

        [Fact(DisplayName = "Vogal ã")]
        public void Vogalã() 
        {
            const char letter = 'ã';

            Assert.True(letter.IsVowel());
        }

        [Fact(DisplayName = "Vogal Ã")]
        public void VogalÃ() 
        {
            const char letter = 'Ã';

            Assert.True(letter.IsVowel());
        }

        [Fact(DisplayName = "Vogal b")]
        public void Consoanteb() 
        {
            const char letter = 'b';

            Assert.True(letter.IsConsonant());
        }

        [Fact(DisplayName = "Vogal B")]
        public void VogalB() 
        {
            const char letter = 'B';

            Assert.True(letter.IsConsonant());
        }
    }
}