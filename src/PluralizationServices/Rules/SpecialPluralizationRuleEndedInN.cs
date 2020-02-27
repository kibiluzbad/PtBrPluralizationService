namespace PluralizationServices.Rules
{
    using static System.Text.RegularExpressions.Regex;

    internal sealed class SpecialPluralizationRuleEndedInN : PluralizationRule
    {
        private const string Pattern = "[n]$";

        public SpecialPluralizationRuleEndedInN(string word)
            : base(word)
        {
        }

        internal override bool Verify() => IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => $"{this.Word}es";
    }
}
