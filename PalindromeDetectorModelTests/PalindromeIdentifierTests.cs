using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using PalindromeDetectorModel;
using PalindromeDetectorModel.Interfaces;

namespace PalindromeDetectorModelTests
{
    [TestClass]
    public class PalindromeIdentifierTests
    {
        private IPalindromeIdentifier _palindromeIdentifier;

        [TestInitialize]
        public void Initialize()
        {
            _palindromeIdentifier = new PalindromeIdentifier();
        }

        [TestMethod]
        public void GetTopNPalindromesShouldReturnThreePalindromes()
        {
            // Arrange, Act
            List<IPalindrome> result = _palindromeIdentifier.GetTopNPalindromes(
                "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop", 3).ToList();

            // Asset
            Assert.AreEqual(result.Count, 3);
            Assert.AreEqual(result[0].Text, "hijkllkjih");
            Assert.AreEqual(result[1].Text, "defggfed");
            Assert.AreEqual(result[2].Text, "abccba");
        }

        [TestMethod]
        public void GetTopNPalindromesShouldReturnUniquePalindromesWhenAStringWithDuplicatesSupplied()
        {
            // Arrange, Act
            List<IPalindrome> result = _palindromeIdentifier.GetTopNPalindromes(
                "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop",
                3).ToList();

            // Assert
            Assert.AreEqual(result.Count, 3);
            Assert.AreEqual(result[0].Text, "hijkllkjih");
            Assert.AreEqual(result[1].Text, "defggfed");
            Assert.AreEqual(result[2].Text, "abccba");
        }

        [TestMethod]
        public void GetTopNPalindromeShouldReturnEmptyListWhenAnEmptyStringIsSupplied()
        {
            // Arrange, Act
            object result = _palindromeIdentifier.GetTopNPalindromes(string.Empty, 3);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void IsPalindromeShouldReturnFalseIfEmptyStringIsSupplied()
        {
            // Arrange
            bool result = _palindromeIdentifier.IsPalindrome(string.Empty);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindromeShouldReturnFalseIfNullIsSupplied()
        {
            // Arrange
            bool result = _palindromeIdentifier.IsPalindrome(string.Empty);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindromeShouldReturnTrueIfSuppliedStringIsPalindrome()
        {
            // Arrange
            bool result = _palindromeIdentifier.IsPalindrome("SAS");

            // Assert
            Assert.IsTrue(result);
        }
    }
}
