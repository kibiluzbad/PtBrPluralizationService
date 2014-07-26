using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PluralizationServices.Rules.RuleEndedInL 
{
    public class SpecialPluralizationRuleEndedInUl : IPluralizationRule 
    {
        private readonly IDictionary<string, string> _exceptions = new Dictionary<string, string> 
        {
            {"cônsul", "cônsules"}
        };

        private const string Pattern = "ul$";

        public string Word { get; set; }

        public bool Verify() 
        {
            return _exceptions.ContainsKey(Word) || Regex.IsMatch(Word, Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public string Apply() 
        {
            return _exceptions.ContainsKey(Word) ? _exceptions[Word] : Regex.Replace(Word, Pattern, "uis");
        }
    }
}