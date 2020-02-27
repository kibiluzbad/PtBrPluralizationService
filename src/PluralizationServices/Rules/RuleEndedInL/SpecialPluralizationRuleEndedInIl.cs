namespace PluralizationServices.Rules.RuleEndedInL
{
    using static System.Text.RegularExpressions.Regex;

    using static PluralizationServices.Rules.PluralizationRule;

    internal sealed class SpecialPluralizationRuleEndedInIl : PluralizationRule
    {
        private const string Pattern = "il$";

        public SpecialPluralizationRuleEndedInIl(string word)
            : base(word)
        {
        }

        internal override bool Verify() => IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply()
        {
            if (IsMatch(this.Word, "[áéêíó]", RegexOptions))
            {
                return Replace(this.Word, Pattern, "eis");
            }

            return Replace(this.Word, Pattern, "is");
        }
    }
}
