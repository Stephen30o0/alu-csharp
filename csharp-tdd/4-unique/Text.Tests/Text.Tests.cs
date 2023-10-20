using Microsoft.VisualStudio.TestTools.UnitTesting;
using Text;

namespace Text.Tests
{
    [TestClass]
    public class StrTests
    {
        [TestMethod]
        public void UniqueChar_ValidString_ReturnsIndex()
        {
            string input = "abcdefghijklmnopqrstuvwxyz";

            int result = Str.UniqueChar(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void UniqueChar_RepeatingCharacters_ReturnsIndex()
        {
            string input = "abcddcba";

            int result = Str.UniqueChar(input);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void UniqueChar_EmptyString_ReturnsNegativeOne()
        {
            string input = "";

            int result = Str.UniqueChar(input);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void UniqueChar_NullString_ReturnsNegativeOne()
        {
            string input = null;

            int result = Str.UniqueChar(input);

            Assert.AreEqual(-1, result);
        }
    }
}
