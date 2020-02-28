namespace PluralizationServices.Rules
{
    using static System.Text.RegularExpressions.Regex;

    internal sealed class BasicPluralizationRule : PluralizationRule
    {
        private const string Pattern = "[aeiouã]$";

        public BasicPluralizationRule(string word)
            : base(word)
        {
        }

        internal override bool Verify() => IsMatch(this.Word, Pattern, RegexOptions);

        internal override string Apply() => $"{this.Word}s";
    }
}
