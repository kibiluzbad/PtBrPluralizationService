namespace PluralizationServices.Rules.RuleEndedInL
{
    using System.Collections.Generic;

    using static System.Text.RegularExpressions.Regex;

    internal sealed class SpecialPluralizationRuleEndedInAl : PluralizationRule
    {
        private const string Pattern = "al$";
        private static readonly IReadOnlyDictionary<string, string> Exceptions = new Dictionary<string, string>
        {
            { "mal", "males" },
            { "real", "réis" },
        };

        public SpecialPluralizationRuleEndedInAl(string word)
            : base(word)
        {
        }

        internal override bool Verify() => Exceptions.ContainsKey(this.Word) || IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => Exceptions.ContainsKey(this.Word)
            ? Exceptions[this.Word]
            : Replace(this.Word, Pattern, "ais");
    }
}
