using System;

namespace PluralizationServices.Extensions 
{
    public static class TonicAccentExtension 
    {
        public static bool IsOxítona(this string word)
        {
            var lastPosition = word.Length - 1;
            var lastCharacter = '\0';
            if (lastPosition > 0) lastCharacter = char.ToLower(word[lastPosition]);

            var penultimatePosition = word.Length - 2;
            var penultimateCharacter = '\0';
            if (penultimatePosition > 0) penultimateCharacter = char.ToLower(word[penultimatePosition]);

            if (lastCharacter.Equals('s') && penultimateCharacter.HasAccent()) return true;
            if (lastCharacter.HasAccent()) return true;

            return false;
        }

        public static bool IsParoxítona(this string word)
        {
            throw new NotImplementedException();
        }
        
        public static bool IsProparoxítonas(this string word)
        {
            throw new NotImplementedException();
        }
    }
}
