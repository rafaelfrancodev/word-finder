using Xunit;
using Test = WordFinder;

namespace UnitTest
{
    public class WordFinderTest
    {
        private string[] _columnLetters = new string[] { "abcdc", "fgwio", "chill", "pqnsd", "uvdxy" };


        [Theory]
        [InlineData("chill")]
        [InlineData("wind")]
        [InlineData("cold")]
        public void ShouldFoundWord(string word)
        {
            //arr
            var wordsInput = new string[] { word };      

            //act
            var result = new Test.WordFinder(wordsInput).Find(_columnLetters);

            //assert
            Assert.Single(result);
        }

        [Theory]
        [InlineData("snow")]
        [InlineData("summer")]
        public void ShouldNotFoundWord(string word)
        {
            //arr
            var wordsInput = new string[] { word };           

            //act
            var result = new Test.WordFinder(wordsInput).Find(_columnLetters);

            //assert
            Assert.Empty(result);
        }
    }
}