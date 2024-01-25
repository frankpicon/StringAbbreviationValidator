using Xunit.Abstractions;

namespace GeicoInterviewAppTest
{
    public class StringAbbreviationUnitTest
    {
        private readonly ITestOutputHelper output;
        public StringAbbreviationUnitTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData("foobar", "f2b2")]
        [InlineData("picon", "p3n")]
        [InlineData("foobare", "f2b3")]
        [InlineData("foobar", "g2d3")]
        [InlineData("test", "t2t")]
        [InlineData("test", "t02t")]
        public void isMatchAbbrTest(string data, string abbr)
        {
            output.WriteLine($"data:{data} abbr:{abbr} is Abbreviation = {StringAbbreviation.isMatchAbbr(data, abbr)} ");
            Assert.True(StringAbbreviation.isMatchAbbr(data,abbr));
        }
    }
}