namespace PluralizationServices.Tests.Extensions
{
    using FluentAssertions;

    using PluralizationServices.Extensions;

    using Xunit;

    [Trait("Fonema", "Vogal e consoante")]
    public sealed class PhonemeExtensionTests
    {
        [Theory(DisplayName = "Vogal a, A, ã e Ã")]
        [InlineData('a')]
        [InlineData('A')]
        [InlineData('ã')]
        [InlineData('Ã')]
        public void VogalaA(char letter) => letter.IsVowel().Should().BeTrue();

        [Theory(DisplayName = "Consoante b e B")]
        [InlineData('b')]
        [InlineData('B')]
        public void ConsoantebB(char letter) => letter.IsConsonant().Should().BeTrue();
    }
}
