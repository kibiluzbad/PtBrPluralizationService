namespace PluralizationServices.Rules.RuleEndedInL
{
    using static System.Text.RegularExpressions.Regex;

    internal sealed class SpecialPluralizationRuleEndedInOl : PluralizationRule
    {
        private const string Pattern = "ol$";

        public SpecialPluralizationRuleEndedInOl(string word)
            : base(word)
        {
        }

        internal override bool Verify() => IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => Replace(this.Word, Pattern, "óis");
    }
}
