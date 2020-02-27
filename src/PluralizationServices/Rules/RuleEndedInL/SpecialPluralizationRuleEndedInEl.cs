namespace PluralizationServices.Rules.RuleEndedInL
{
    using static System.Text.RegularExpressions.Regex;

    internal sealed class SpecialPluralizationRuleEndedInEl : PluralizationRule
    {
        private const string Pattern = "el$";

        public SpecialPluralizationRuleEndedInEl(string word)
            : base(word)
        {
        }

        internal override bool Verify() => IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => Replace(this.Word, Pattern, "éis");
    }
}
