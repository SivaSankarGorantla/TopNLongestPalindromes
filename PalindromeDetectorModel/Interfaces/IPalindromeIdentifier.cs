//----------------------------------------------------------------------------
// <summery>
// This interface represents the behaviour of a palindrome identifier.
// <summery>
//----------------------------------------------------------------------------

using System.Collections.Generic;

namespace PalindromeDetectorModel.Interfaces
{
    public interface IPalindromeIdentifier
    {
        /// <summary>
        /// Gets list of palindromes in the given string.
        /// </summary>
        /// <param name="input">input provided by the end-user.</param>
        /// <returns>List of all unique palindromes.</returns>
        IEnumerable<IPalindrome> GetPalindromes(string input);

        /// <summary>
        /// Gets top n palindromes in the given string.
        /// </summary>
        /// <param name="input">input provided by the end-user.</param>
        /// <param name="numberOfPalindromesToProcess">number of top palindromes to return.</param>
        /// <returns>top n palindromes in the given string</returns>
        IEnumerable<IPalindrome> GetTopNPalindromes(string input, int numberOfPalindromesToProcess);

        /// <summary>
        /// Checks if the given string is a palindrome.
        /// </summary>
        /// <param name="input">string to be checked</param>
        /// <returns>true if the string is palindrome. Otherwise false.</returns>
        bool IsPalindrome(string input);

        /// <summary>
        /// Sets the cancellation token to true so that all operation on the current instance is cancelled-
        /// until a new cancel token is generated.
        /// </summary>
        void CancelOperation();
    }
}
