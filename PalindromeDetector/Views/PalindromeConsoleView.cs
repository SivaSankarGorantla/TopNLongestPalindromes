//----------------------------------------------------------------------------
// <summery>
// This class is responsible to process user input and produce output.
// <summery>
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Threading;
using PalindromeDetectorModel;
using PalindromeDetectorModel.Entities;
using PalindromeDetectorModel.Interfaces;

namespace PalindromeDetector.Views
{
    class PalindromeConsoleView
    {
        static void Main()
        {
            string input = GetInputString();
            IPalindromeIdentifier palindrome = new PalindromeIdentifier();
            IEnumerable<IPalindrome> palindromes = palindrome.GetTopNPalindromes(input, 3, new CancellationTokenSource());
            DisplayResults(palindromes);
        }

        private static void DisplayResults(IEnumerable<IPalindrome> palindromes)
        {
            if (palindromes == null)
            {
                return;
            }
            
            foreach (IPalindrome palindrome in palindromes)
            {
                Console.WriteLine(palindrome.ConvertToString());
            }
        }


        /// <summary>
        /// Reads the input from console. e.g. sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop
        /// </summary>
        /// <returns>Input string given by the end-user.</returns>
        private static string GetInputString()
        {
            return Console.ReadLine();
        }
    }
}
