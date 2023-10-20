using Microsoft.VisualStudio.TestTools.UnitTesting;
using Text;

namespace Text.Tests
{
    [TestClass]
    public class StrTests
    {
        [TestMethod]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            string palindrome = "Racecar";

            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_ValidPalindromeWithSpacesAndPunctuation_ReturnsTrue()
        {
            string palindrome = "A man, a plan, a canal: Panama.";

            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_ValidPalindromeWithDifferentCasing_ReturnsTrue()
        {
            string palindrome = "LeVel";

            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_NotAPalindrome_ReturnsFalse()
        {
            string notAPalindrome = "Hello, World!";

            bool result = Str.IsPalindrome(notAPalindrome);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            string emptyString = "";

            bool result = Str.IsPalindrome(emptyString);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            string nullString = null;

            bool result = Str.IsPalindrome(nullString);

            Assert.IsTrue(result);
        }
    }
}
