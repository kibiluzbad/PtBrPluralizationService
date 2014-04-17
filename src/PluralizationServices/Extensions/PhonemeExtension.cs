using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace PluralizationServices.Extensions 
{
    public static class PhonemeExtension
    {
        private const RegexOptions OptionsRegex = RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline;

        public static bool HasAccent(this char letter)
        {
            var input = letter.ToString(CultureInfo.InvariantCulture);

            const string vowelsWithAccentsPattern = "[áéíóúàèìòùâêîôûäëïöüãõ]";

            return Regex.IsMatch(input, vowelsWithAccentsPattern, OptionsRegex);
        }

        public static bool IsVowel(this char letter)
        {
            var input = letter.ToString(CultureInfo.InvariantCulture);

            if (HasAccent(letter)) return true;

            const string vowelsWithoutAccentsPattern = "[aeiou]";
            if (Regex.IsMatch(input, vowelsWithoutAccentsPattern, OptionsRegex)) return true;

            return false;
        }

        public static bool IsConsonant(this char letter)
        {
            if (letter.Equals('\0')) return true;
            if (!char.IsDigit(letter) && !IsVowel(letter)) return true;

            return false;
        }

        public static bool In(this char letter, char[] collection)
        {
            return collection.Any(item => item.Equals(letter));
        }
    }
}
