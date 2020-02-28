namespace PluralizationServices.Rules
{
    using static System.Text.RegularExpressions.Regex;

    internal sealed class SpecialSingularizeRuleEndedInRZ : PluralizationRule
    {
        private const string Pattern = "(?<vogal>[rz])es$";

        public SpecialSingularizeRuleEndedInRZ(string word)
            : base(word)
        {
        }

        internal override bool Verify() => IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => Replace(this.Word, Pattern, m => m.Groups["vogal"].Value);
    }
}
