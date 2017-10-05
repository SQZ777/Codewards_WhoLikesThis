using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewards_Who_likes_it
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_Null_Should_Be_noOneLikeThis()
        {
            string[] input = null;

            var actual = Kata.Likes(input);

            var expected = "no one likes this";

            Assert.AreEqual(expected, actual);
        }

    }

    public class Kata
    {
        public static string Likes(string[] input)
        {
            throw new System.NotImplementedException();
        }
    }
}
