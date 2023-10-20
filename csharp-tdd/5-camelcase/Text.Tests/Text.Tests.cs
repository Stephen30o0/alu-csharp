using Microsoft.VisualStudio.TestTools.UnitTesting;
using Text;

namespace Text.Tests
{
    [TestClass]
    public class StrTests
    {
        [TestMethod]
        public void CamelCase_ValidString_ReturnsWordCount()
        {
            string input = "thisIsACamelCaseString";

            int result = Str.CamelCase(input);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            string input = "";

            int result = Str.CamelCase(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CamelCase_NullString_ReturnsZero()
        {
            string input = null;

            int result = Str.CamelCase(input);

            Assert.AreEqual(0, result);
        }
    }
}
