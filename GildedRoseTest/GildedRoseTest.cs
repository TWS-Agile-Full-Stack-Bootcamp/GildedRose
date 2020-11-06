using Xunit;
using System.Collections.Generic;
using GildedRose;
using System.Text;
using System;
using System.IO;

namespace GildedRoseTest
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.Equal("foo", items[0].Name);
        }

        [Fact]
        public void ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            //File.WriteAllText("WriteLines4.txt", output);

            string text = System.IO.File.ReadAllText("WriteLines4.txt");

            Assert.Equal(text, output);
        }
    }
}
