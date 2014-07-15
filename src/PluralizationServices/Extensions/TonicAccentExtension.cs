using System;
using PluralizationServices.TonicAccent;

namespace PluralizationServices.Extensions
{
    public static class TonicAccentExtension
    {
        private static ITonicAccent _tonicAccent;

        public static bool IsOxitona(this string word)
        {
            _tonicAccent = new OxitonaTonicAccent();

            return _tonicAccent.Verify(word);
        }

        public static bool IsParoxitona(this string word)
        {
            throw new NotImplementedException();
        }

        public static bool IsProparoxitonas(this string word)
        {
            throw new NotImplementedException();
        }
    }
}
