namespace PluralizationServices.Rules
{
    using static System.Text.RegularExpressions.Regex;

    internal sealed class SpecialPluralizationRuleEndedInRZ : PluralizationRule
    {
        private const string Pattern = "[rz]$";

        public SpecialPluralizationRuleEndedInRZ(string word)
            : base(word)
        {
        }

        internal override bool Verify() => IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => $"{this.Word}es";
    }
}
