using Xunit;

namespace GildedRoseTest
{
    public class SampleTest
    {
        [Fact]
        public void Test()
        {
            string text = System.IO.File.ReadAllText("sample.approved.txt");

            Assert.Equal("Approved result", text);
        }
    }
}
