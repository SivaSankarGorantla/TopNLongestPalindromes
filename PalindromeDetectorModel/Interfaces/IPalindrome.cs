//----------------------------------------------------------------------------
// <summery>
// This interface represents the behaviour of a palindrome.
// <summery>
//----------------------------------------------------------------------------

namespace PalindromeDetectorModel.Interfaces
{
    public interface IPalindrome
    {
        /// <summary>
        /// Get or sets a value indicating the text of palindrome.
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Gets or sets the palindromes starting index.
        /// </summary>
        int Index { get; set; }

        /// <summary>
        /// Gets or sets the length of the palindrome.
        /// </summary>
        int Length { get; set; }

        /// <summary>
        /// Converts the current object to a string representable format.
        /// </summary>
        /// <returns>returns the palindrome object in a given format</returns>
        string ConvertToString(string format);
    }
}
