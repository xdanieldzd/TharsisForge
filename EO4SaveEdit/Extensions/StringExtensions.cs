using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EO4SaveEdit.Extensions
{
    public static class StringExtensions
    {
        static Dictionary<char, char> asciiTranslator = new Dictionary<char, char>()
        {
            { '　', ' ' }, { '，', ',' }, { '．', '.' }, { '：', ':' }, { '；', ';' }, { '？', '?' }, { '！', '!' }, { '－', '-' },
            { '／', '/' }, { '～', '~' }, { '’', '\'' }, { '”', '\"' }, { '（', '(' }, { '）', ')' }, { '［', '[' }, { '］', ']' },
            { '〈', '<' }, { '〉', '>' }, { '＋', '+' }, { '＊', '*' },

            { '０', '0' }, { '１', '1' }, { '２', '2' }, { '３', '3' }, { '４', '4' }, { '５', '5' }, { '６', '6' }, { '７', '7' },
            { '８', '8' }, { '９', '9' },
            
            { 'Ａ', 'A' }, { 'Ｂ', 'B' }, { 'Ｃ', 'C' }, { 'Ｄ', 'D' }, { 'Ｅ', 'E' }, { 'Ｆ', 'F' }, { 'Ｇ', 'G' }, { 'Ｈ', 'H' },
            { 'Ｉ', 'I' }, { 'Ｊ', 'J' }, { 'Ｋ', 'K' }, { 'Ｌ', 'L' }, { 'Ｍ', 'M' }, { 'Ｎ', 'N' }, { 'Ｏ', 'O' }, { 'Ｐ', 'P' },
            { 'Ｑ', 'Q' }, { 'Ｒ', 'R' }, { 'Ｓ', 'S' }, { 'Ｔ', 'T' }, { 'Ｕ', 'U' }, { 'Ｖ', 'V' }, { 'Ｗ', 'W' }, { 'Ｘ', 'X' },
            { 'Ｙ', 'Y' }, { 'Ｚ', 'Z' },
            
            { 'ａ', 'a' }, { 'ｂ', 'b' }, { 'ｃ', 'c' }, { 'ｄ', 'd' }, { 'ｅ', 'e' }, { 'ｆ', 'f' }, { 'ｇ', 'g' }, { 'ｈ', 'h' },
            { 'ｉ', 'i' }, { 'ｊ', 'j' }, { 'ｋ', 'k' }, { 'ｌ', 'l' }, { 'ｍ', 'm' }, { 'ｎ', 'n' }, { 'ｏ', 'o' }, { 'ｐ', 'p' },
            { 'ｑ', 'q' }, { 'ｒ', 'r' }, { 'ｓ', 's' }, { 'ｔ', 't' }, { 'ｕ', 'u' }, { 'ｖ', 'v' }, { 'ｗ', 'w' }, { 'ｘ', 'x' },
            { 'ｙ', 'y' }, { 'ｚ', 'z' },
        };

        static Dictionary<char, char> sjisTranslator = asciiTranslator.ToDictionary(x => x.Value, x => x.Key);

        private static char TryFetchCharacter(Dictionary<char, char> dict, char key)
        {
            if (dict.ContainsKey(key)) return dict[key];
            else return key;
        }

        public static string SjisToAscii(this string inputString)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char ch in inputString) builder.Append(TryFetchCharacter(asciiTranslator, ch));
            return builder.ToString();
        }

        public static string AsciiToSjis(this string inputString)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char ch in inputString) builder.Append(TryFetchCharacter(sjisTranslator, ch));
            return builder.ToString();
        }

        public static byte[] GetSjisBytes(this string inputString, int length)
        {
            List<byte> stringBytes = new List<byte>();
            stringBytes.AddRange(Encoding.GetEncoding(932).GetBytes(inputString.AsciiToSjis()));
            while (stringBytes.Count < length) stringBytes.Add(0);
            return stringBytes.Take(length).ToArray();
        }
    }
}
