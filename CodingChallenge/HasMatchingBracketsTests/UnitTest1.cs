using CodingChallenge;
using NUnit.Framework;

namespace HasMatchingBracketsTests
{
    public class HasMatchingBracketsUnitTests
    {
        [Test]
        public void EmptyStringTest()
        {
            Assert.IsTrue(HasMatchingBracketsClass.HasMatchingBrackets(""));
        }
        
        [Test]
        public void EmptySingleBracketsTest()
        {
            Assert.IsTrue(HasMatchingBracketsClass.HasMatchingBrackets("{}"));
        }
        
        [Test]
        public void InvalidSingleBracketsTest()
        {
            Assert.IsFalse(HasMatchingBracketsClass.HasMatchingBrackets("}{"));
        }
        
        [Test]
        public void SingleOpenBracketTest()
        {
            Assert.IsFalse(HasMatchingBracketsClass.HasMatchingBrackets("{"));
        }
        
        [Test]
        public void SingleCloseBracketTest()
        {
            Assert.IsFalse(HasMatchingBracketsClass.HasMatchingBrackets("}"));
        }
        
        [Test]
        [TestCase("{{}")]
        [TestCase("{{{}}")]
        [TestCase("{{{{}}}")]
        [Parallelizable(ParallelScope.All)]
        public void TooManyOpenBracketsTest(string testString)
        {
            Assert.IsFalse(HasMatchingBracketsClass.HasMatchingBrackets(testString));
        }
        
        [Test]
        [TestCase("{}}")]
        [TestCase("{{}}}")]
        [TestCase("{{{}}}}")]
        [Parallelizable(ParallelScope.All)]
        public void TooManyCloseBracketsTest(string testString)
        {
            Assert.IsFalse(HasMatchingBracketsClass.HasMatchingBrackets(testString));
        }
        
        [Test]
        [TestCase("{abc...xyz}")]
        [TestCase("{a{b{c}d}e}")]
        [TestCase("{ { { } } }")]
        [TestCase("abcdefghijklmnopqrstuvwxyz{#${(*{ ()()()(()}@!#$ ~} -----}++++    \r\n")]
        [TestCase("{\n{\n{\n}\n}\n}\n")]
        [Parallelizable(ParallelScope.All)]
        public void IgnoresNonBracketCharactersTest(string testString)
        {
            Assert.IsTrue(HasMatchingBracketsClass.HasMatchingBrackets(testString));
        }
    }
}