namespace PluralizationServices.Rules
{
    using System.Text.RegularExpressions;

    using static System.Text.RegularExpressions.RegexOptions;

    internal abstract class PluralizationRule
    {
        protected const RegexOptions RegexOptions = Compiled | IgnoreCase | Singleline;

        protected PluralizationRule(string word) => this.Word = word;

        protected string Word { get; }

        internal abstract bool Verify();

        internal abstract string Apply();
    }
}
