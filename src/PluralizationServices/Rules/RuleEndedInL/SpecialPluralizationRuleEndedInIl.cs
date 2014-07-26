using System.Text.RegularExpressions;

namespace PluralizationServices.Rules.RuleEndedInL 
{
    public class SpecialPluralizationRuleEndedInIl : IPluralizationRule 
    {
        private const string Pattern = "il$";

        public string Word { get; set; }

        public bool Verify() 
        {
            return Regex.IsMatch(Word, Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public string Apply()
        {
            if (Regex.IsMatch(Word, "[áéêíó]", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                return Regex.Replace(Word, Pattern, "eis");

            return Regex.Replace(Word, Pattern, "is");
        }
    }
}