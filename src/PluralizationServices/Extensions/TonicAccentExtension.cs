namespace PluralizationServices.Extensions
{
    using PluralizationServices.TonicAccent;

    public static class TonicAccentExtension
    {
        public static bool IsOxitona(this string word) => new OxitonaTonicAccent().Verify(word);
    }
}
