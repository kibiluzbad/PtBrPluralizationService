using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PluralizationServices.Rules.RuleEndedInL 
{
    public class SpecialPluralizationRuleEndedInAl : IPluralizationRule
    {
        private readonly IDictionary<string, string> _exceptions  = new Dictionary<string, string> 
        {
            {"mal", "males"},
            {"real", "réis"}
        };

        private const string Pattern = "al$";

        public string Word { get; set; }

        public bool Verify()
        {
            return _exceptions.ContainsKey(Word) || Regex.IsMatch(Word, Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public string Apply()
        {
            return _exceptions.ContainsKey(Word) ? _exceptions[Word] : Regex.Replace(Word, Pattern, "ais");
        }
    }
}