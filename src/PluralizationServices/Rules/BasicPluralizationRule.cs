using System.Text.RegularExpressions;

namespace PluralizationServices.Rules
{
    public class BasicPluralizationRule : IPluralizationRule
    {
        public string Word { get; set; }

        public bool Verify()
        {
            return Regex.IsMatch(Word, "[aeiouã]$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public string Apply()
        {
            return string.Concat(Word, "s");
        }
    }
}
