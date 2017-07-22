using NUnit.Framework;
using System;

namespace PrimeString
{
    [TestFixture]
    public class KataTest
    {
        [TestCase("x", ExpectedResult = true)]
        [TestCase("abc", ExpectedResult = true)]
        [TestCase("abac", ExpectedResult = true)]
        [TestCase("abab", ExpectedResult = false)]
        [TestCase("aaaa", ExpectedResult = false)]
        [TestCase("abba", ExpectedResult = true)]
        [TestCase("utdutdtdutd", ExpectedResult = true)]
        [TestCase("fdsyffdsyffdsyffdsyffdsyf", ExpectedResult = false)]
        public bool BasicTests(string input)
        {
            var kata = new Kata();
            return kata.PrimeString(input);
        }
    }
}