using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PalindromeDetectorModel;
using PalindromeDetectorModel.Interfaces;

namespace PalindromeDetectorRichUI.ViewModels
{
    class PalindromeViewModel
    {
        private readonly IPalindromeIdentifier _palindromeIdentifier;
        private readonly ObservableCollection<string> _listOfPalindromes;
        private Task _currentTask;

        public PalindromeViewModel(IPalindromeIdentifier palindromeIdentifierObject)
        {
            _palindromeIdentifier = palindromeIdentifierObject;
            _listOfPalindromes = new ObservableCollection<string>();
        }

        public string Input { get; set; }

        public ObservableCollection<string> Palindromes => _listOfPalindromes;

        public void FindPalindromes()
        {
            try
            {
                string input = Input;

                if (string.IsNullOrWhiteSpace(input))
                {
                    return;
                }


                List<IPalindrome> listOfLongestPalindromes = new List<IPalindrome>();

                _currentTask = Task.Run(() =>
                {
                    listOfLongestPalindromes = _palindromeIdentifier
                        .GetTopNPalindromes(input, Constants.NumberOfPalindromesToProcess).ToList();
                }).ContinueWith((t2) =>
                {
                    Application.Current.Dispatcher.Invoke(
                        () =>
                        {
                            if (listOfLongestPalindromes.Count > 0)
                            {
                                foreach (IPalindrome palindrome in listOfLongestPalindromes)
                                {
                                    _listOfPalindromes.Add(palindrome.ConvertToString(Constants.DisplayFormat));
                                }
                            }
                            else
                            {
                                _listOfPalindromes.Add(@"No palindromes found!");
                            }
                        });
                });

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public void Reset()
        {
            if (_currentTask != null)
            {
                _palindromeIdentifier.CancelOperation();
                _listOfPalindromes.Clear();
            }

        }
    }
}
