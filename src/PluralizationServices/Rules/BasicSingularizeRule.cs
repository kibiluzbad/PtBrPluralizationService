using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PluralizationServices.Rules
{
    public class BasicSingularizeRule : IPluralizationRule
    {
        private const string Pattern = "[aeiouã](?<plural>s)";

        public string Word { get; set; }

        public bool Verify()
        {
            return Regex.IsMatch(Word, Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public string Apply()
        {
            return Regex.Replace(Word, Pattern, m =>
                Word.Replace(m.Groups["plural"].Value, string.Empty));
        }
    }
}
