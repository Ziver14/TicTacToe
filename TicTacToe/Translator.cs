using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Translator
    {
        private static Dictionary<char, string> morseCodeDict = new Dictionary<char, string>
            {
                {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
                {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
                {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
                {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
                {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"}, {'Z', "--.."}
            };

        public static string TextToMorse(string text)
        {
            string morseCode = "";
            foreach (char c in text.ToUpper())
            {
                if (morseCodeDict.ContainsKey(c))
                {
                    morseCode += morseCodeDict[c] + " ";
                }
                else if (c == ' ')
                {
                    morseCode += "/ ";
                }
            }
            return morseCode.Trim();
        }

        public static string MorseToText(string morseCode)
        {
            string text = "";
            string[] morseChars = morseCode.Split(' ');
            foreach (string morseChar in morseChars)
            {
                if (morseChar == "/")
                {
                    text += " ";
                }
                else
                {
                    foreach (KeyValuePair<char, string> kvp in morseCodeDict)
                    {
                        if (kvp.Value == morseChar)
                        {
                            text += kvp.Key;
                            break;
                        }
                    }
                }
            }
            return text;
        }
    }
}

