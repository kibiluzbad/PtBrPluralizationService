namespace PluralizationServices.TonicAccent
{
    using System.Text.RegularExpressions;

    using static System.Text.RegularExpressions.RegexOptions;

    internal interface ITonicAccent
    {
        protected const RegexOptions RegexOptions = Compiled | IgnoreCase | Singleline;

        bool Verify(string word);
    }
}
