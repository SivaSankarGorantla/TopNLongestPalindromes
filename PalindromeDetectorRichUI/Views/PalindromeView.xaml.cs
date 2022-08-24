using System.Windows;
using PalindromeDetectorModel;
using PalindromeDetectorRichUI.ViewModels;

namespace PalindromeDetectorRichUI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PalindromeViewModel _palindromeViewModel;
        public MainWindow()
        {
            InitializeComponent();
            _palindromeViewModel = new PalindromeViewModel(new PalindromeIdentifier());
            DataContext = _palindromeViewModel;
        }

        /// <summary>
        /// Find palindrome in a given string.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindPalindromes_Click(object sender, RoutedEventArgs e)
        {
            _palindromeViewModel.Reset();

            _palindromeViewModel.FindPalindromes();

        }
    }
}
