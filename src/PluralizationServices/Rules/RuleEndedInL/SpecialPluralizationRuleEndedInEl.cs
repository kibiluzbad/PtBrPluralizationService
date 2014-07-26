using System.Text.RegularExpressions;

namespace PluralizationServices.Rules.RuleEndedInL 
{
    public class SpecialPluralizationRuleEndedInEl : IPluralizationRule 
    {
        private const string Pattern = "el$";

        public string Word { get; set; }

        public bool Verify() 
        {
            return Regex.IsMatch(Word, Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public string Apply() 
        {
            return Regex.Replace(Word, Pattern, "éis");
        }
    }
}