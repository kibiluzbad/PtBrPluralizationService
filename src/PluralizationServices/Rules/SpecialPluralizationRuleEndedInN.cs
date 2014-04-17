using System.Text.RegularExpressions;

namespace PluralizationServices.Rules 
{
    public class SpecialPluralizationRuleEndedInN : IPluralizationRule 
    {
        public string Word { get; set; }

        public bool Verify() 
        {
            return Regex.IsMatch(Word, "[n]$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public string Apply() 
        {
            return string.Concat(Word, "es");
        }
    }
}