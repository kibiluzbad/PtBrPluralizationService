namespace PluralizationServices.TonicAccent
{
    using static System.Text.RegularExpressions.Regex;

    using static PluralizationServices.TonicAccent.ITonicAccent;

    internal sealed class OxitonaTonicAccent : ITonicAccent
    {
        private const string Pattern = "[áâéêóôiíuú]s?$|m$|ns$";

        public bool Verify(string word) => IsMatch(RemovePronoun(word), Pattern, RegexOptions);

        private static string RemovePronoun(string word) => word.Split('-')[0];
    }
}
