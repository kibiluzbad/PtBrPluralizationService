namespace PluralizationServices.Rules
{
    using static System.Text.RegularExpressions.Regex;

    internal sealed class BasicSingularizeRule : PluralizationRule
    {
        private const string Pattern = "(?<vogal>[aeiouã])s$";

        public BasicSingularizeRule(string word)
            : base(word)
        {
        }

        internal override bool Verify() => IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => Replace(this.Word, Pattern, m => m.Groups["vogal"].Value);
    }
}
