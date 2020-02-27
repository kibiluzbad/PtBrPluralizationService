namespace PluralizationServices.Rules.RuleEndedInL
{
    using System.Collections.Generic;

    using static System.Text.RegularExpressions.Regex;

    internal sealed class SpecialPluralizationRuleEndedInUl : PluralizationRule
    {
        private const string Pattern = "ul$";
        private static readonly IReadOnlyDictionary<string, string> Exceptions = new Dictionary<string, string>
        {
            { "cônsul", "cônsules" },
        };

        public SpecialPluralizationRuleEndedInUl(string word)
            : base(word)
        {
        }

        internal override bool Verify() => Exceptions.ContainsKey(this.Word) || IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => Exceptions.ContainsKey(this.Word)
            ? Exceptions[this.Word]
            : Replace(this.Word, Pattern, "uis");
    }
}
