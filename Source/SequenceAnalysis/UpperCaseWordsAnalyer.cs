using SequenceAnalysis.Core;
using SequenceAnalysis.Core.Exceptions;
using System;
using System.Text;

namespace SequenceAnalysis
{
    public class UpperCaseWordsAnalyer : IUpperCaseWordsAnalyzer
    {
        /// <summary>
        /// Analyze upper case words in a given string and returns all characters in all upper case words ordered alphabitically
        /// </summary>
        /// <param name="inputStatement">statement to be analyzed</param>
        /// <returns>
        /// All characters in all upper case words ordered alphabitically
        /// </returns>
        /// <exception cref="SequenceAnalysis.Core.Exceptions.GivenStringIsEmpty">Thrown when given statement string is null or empty</exception>
        public string Analize(string inputStatement)
        {
            if (string.IsNullOrEmpty(inputStatement))
                throw new GivenStringIsEmpty();

            // split statement on white spaces and remove empty enteries
            string[] words = inputStatement.Split(new string[] { " ", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int[] lettersExistence = new int[256];
            foreach (string word in words)
            {
                string wordUpperCaseLetters = analyzeWord(word);
                foreach (char upperCaseCharacter in wordUpperCaseLetters)
                {
                    Int16 characterAsAscii = Convert.ToInt16(upperCaseCharacter);
                    lettersExistence[characterAsAscii]++;
                }
            }

            StringBuilder resultSb = new StringBuilder();
            for (int characterAsAscii = 65; characterAsAscii < lettersExistence.Length; characterAsAscii++)
            {
                char character = Convert.ToChar(characterAsAscii);
                for (int i = 0; i < lettersExistence[characterAsAscii]; i++)
                {
                    resultSb.Append(character);
                }
            }

            return resultSb.ToString();
        }

        private string analyzeWord(string word)
        {
            bool hasLetters = false;
            StringBuilder upperCaseLetters = new StringBuilder();
            bool isWordUpperCase = true;
            foreach (char character in word)
            {
                if (char.IsLetter(character))
                {
                    hasLetters = true;
                    if (char.IsUpper(character))
                    {
                        upperCaseLetters.Append(character);
                    }
                    else
                    {
                        isWordUpperCase = false;
                        break;
                    }
                }
            }

            if (hasLetters && isWordUpperCase)
            {
                return upperCaseLetters.ToString();
            }

            return string.Empty;
        }
    }
}
