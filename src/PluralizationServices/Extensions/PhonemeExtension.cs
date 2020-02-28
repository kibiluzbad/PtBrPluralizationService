namespace PluralizationServices.Extensions
{
    using System.Text.RegularExpressions;

    using static System.Char;
    using static System.Globalization.CultureInfo;
    using static System.Text.RegularExpressions.Regex;
    using static System.Text.RegularExpressions.RegexOptions;

    public static class PhonemeExtension
    {
        private const RegexOptions OptionsRegex = Compiled | IgnoreCase | Singleline;

        public static bool HasAccent(this char letter) => IsMatch(letter.ToString(InvariantCulture), "[áéíóúàèìòùâêîôûäëïöüãõ]", OptionsRegex);

        public static bool IsVowel(this char letter) => HasAccent(letter) || IsMatch(letter.ToString(InvariantCulture), "[aeiou]", OptionsRegex);

        public static bool IsConsonant(this char letter) => letter switch
        {
            '\0' => true,
            { } when !IsDigit(letter) && !IsVowel(letter) => true,
            _ => false
        };
    }
}
