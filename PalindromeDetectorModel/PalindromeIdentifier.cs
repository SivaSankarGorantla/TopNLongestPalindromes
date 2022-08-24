//---------------------------------------------------------------------------------
// <summery>
// This class is responsible to identify any palindromes in the given input.
// <summery>
//---------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using PalindromeDetectorModel.Entities;
using PalindromeDetectorModel.Interfaces;

namespace PalindromeDetectorModel
{
    public class PalindromeIdentifier: IPalindromeIdentifier
    {
        private CancellationTokenSource _tokenSource;

        public PalindromeIdentifier()
        {
            _tokenSource = new CancellationTokenSource();
        }

        /// <summary>
        /// Gets list of palindromes in the given string.
        /// </summary>
        /// <param name="input">input provided by the end-user.</param>
        /// <returns>List of all unique palindromes.</returns>
        public IEnumerable<IPalindrome> GetPalindromes(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            List<IPalindrome> palindromes = new List<IPalindrome>();

            for (int beginIndex = 0; beginIndex < input.Length - 1; beginIndex++)
            {
                if (_tokenSource.IsCancellationRequested)
                {
                    palindromes.Clear();
                    return palindromes;
                }

                for (int endIndex = beginIndex + Constants.MinLengthOfPalindrome; endIndex <= input.Length; endIndex++)
                {
                    if (_tokenSource.IsCancellationRequested)
                    {
                        palindromes.Clear();
                        return palindromes;
                    }

                    if (endIndex - beginIndex > 1 && input[endIndex - 1] == input[beginIndex])
                    {
                        string currentSubstring = input.Substring(beginIndex, endIndex - beginIndex);

                        if (IsPalindrome(currentSubstring))
                        {
                            Palindrome palindrome = new Palindrome
                            {
                                Text = currentSubstring,
                                Length = endIndex - beginIndex,
                                Index = beginIndex
                            };

                            palindromes.Add(palindrome);

                            // This is to process unique palindromes.
                            beginIndex = beginIndex + currentSubstring.Length - 1;
                        }
                    }
                }
            }
            return palindromes;
        }

        /// <summary>
        /// Gets top n palindromes in the given string.
        /// </summary>
        /// <param name="input">input provided by the end-user.</param>
        /// <param name="numberOfPalindromesToProcess">number of top palindromes to return.</param>
        /// <returns>top n palindromes in the given string</returns>
        public IEnumerable<IPalindrome> GetTopNPalindromes(string input, int numberOfPalindromesToProcess)
        {

            IEnumerable<IPalindrome> distinctList = GetPalindromes(input)?.GroupBy(x => x.Text)?.Select(y => y?.First());

            return distinctList?.OrderByDescending(p => p.Length).Take(numberOfPalindromesToProcess);
        }

        /// <summary>
        /// Checks if the given string is a palindrome.
        /// </summary>
        /// <param name="input">string to be checked</param>
        /// <returns>true if the string is palindrome. Otherwise false.</returns>
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            StringBuilder reverse = new StringBuilder();

            for (int index = input.Length - 1; index >= 0; index--)
            {
                if (_tokenSource.IsCancellationRequested)
                {
                    return false;
                }

                reverse.Append(input[index]);
            }

            return input == reverse.ToString();
        }

        /// <summary>
        /// Cancels the current operation being executed.
        /// </summary>
        public void CancelOperation()
        {
            _tokenSource?.Cancel();
            _tokenSource = new CancellationTokenSource();
        }
    }
}
