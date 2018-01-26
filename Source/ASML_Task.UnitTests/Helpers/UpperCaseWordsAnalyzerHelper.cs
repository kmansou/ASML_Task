using SequenceAnalysis.Core;
using SequenceAnalysis.Core.Exceptions;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ASML_Task.UnitTests.Helpers
{
    internal class UpperCaseWordsAnalyzerHelper : IUpperCaseWordsAnalyzer
    {
        public string Analize(string inputStatement)
        {
            if (string.IsNullOrEmpty(inputStatement))
                throw new GivenStringIsEmpty();

            string[] words = inputStatement.Split(new string[] { " ", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var upperCaseWords = words.Where(w => string.Equals(w, w.ToUpper(), StringComparison.Ordinal));

            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (string upperCaseWord in upperCaseWords)
            {
                if(!string.IsNullOrEmpty(upperCaseWord))
                {
                    var letters = upperCaseWord.Where(c => char.IsLetter(c));
                    if (letters != null && letters.Any())
                        resultStringBuilder.Append(new string(letters.ToArray()));
                }
            }

            return new string(resultStringBuilder.ToString().OrderBy(c => c).ToArray());
        }
    }
}
