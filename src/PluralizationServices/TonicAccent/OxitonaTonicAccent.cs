using System.Text.RegularExpressions;

namespace PluralizationServices.TonicAccent
{
    public class OxitonaTonicAccent : ITonicAccent
    {
        public bool Verify(string word)
        {
            word = RemovePronoun(word);

            return Regex.IsMatch(word, "[áâéêóôiíuú]s?$|m$|ns$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        private static string RemovePronoun(string word)
        {
            return word.Split('-')[0];
        }
    }
}