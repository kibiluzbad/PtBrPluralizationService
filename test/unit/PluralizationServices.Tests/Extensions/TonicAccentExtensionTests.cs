namespace PluralizationServices.Tests.Extensions
{
    using FluentAssertions;

    using PluralizationServices.Extensions;

    using Xunit;

    [Trait("Acento tônico", "Oxítonas, paroxítonas e proparoxítonas")]
    public sealed class TonicAccentExtensionTests
    {
        [Fact(DisplayName = "Oxítonas ou agudas")]
        public void OxitonasOuAgudas() => "você".IsOxitona().Should().BeTrue();
    }
}
