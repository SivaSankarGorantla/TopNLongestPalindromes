//----------------------------------------------------------------------------
// <summery>
// This class represents the palindrome.
// <summery>
//----------------------------------------------------------------------------

using PalindromeDetectorModel.Interfaces;

namespace PalindromeDetectorModel.Entities
{
    public class Palindrome:IPalindrome
    {
        /// <summary>
        /// Get or sets a value indicating the text of palindrome.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the palindromes starting index.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the length of the palindrome.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Converts the current object to a string representable format.
        /// </summary>
        /// <returns>returns the palindrome object in a given format</returns>
        public string ConvertToString(string format) => string.Format(format, Text, Index, Length);
    }
}
