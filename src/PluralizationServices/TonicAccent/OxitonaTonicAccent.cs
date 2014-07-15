using PluralizationServices.Extensions;

namespace PluralizationServices.TonicAccent
{
    public class OxitonaTonicAccent : ITonicAccent
    {
        public bool Verify(string word)
        {
            word = RemovePronoun(word);
            var lastCharacter = GetLastCharacter(word);
            var penultimateCharacter = GetPenultimateCharacter(word);

            if (lastCharacter.Equals('s') && penultimateCharacter.HasAccent()) return true;
            if (lastCharacter.HasAccent()) return true;
            if (lastCharacter.Equals('m')) return true;
            if (lastCharacter.Equals('m')) return true;
            if (lastCharacter.Equals('s') && penultimateCharacter.Equals('n')) return true;

            return false;
        }

        private static string RemovePronoun(string word)
        {
            return word.Split('-')[0];
        }

        private static char GetPenultimateCharacter(string word)
        {
            var penultimatePosition = word.Length - 2;
            var penultimateCharacter = '\0';
            if (penultimatePosition > 0) penultimateCharacter = char.ToLower(word[penultimatePosition]);
            return penultimateCharacter;
        }

        private static char GetLastCharacter(string word)
        {
            var lastPosition = word.Length - 1;
            var lastCharacter = '\0';
            if (lastPosition > 0) lastCharacter = char.ToLower(word[lastPosition]);
            return lastCharacter;
        }
    }
}