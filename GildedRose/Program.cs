using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> items = new List<Item>
            {
                Item.CreateItem("+5 Dexterity Vest", 10, 20),
                Item.CreateItem("Aged Brie", 2, 0),
                Item.CreateItem("Elixir of the Mongoose", 5, 7),
                Item.CreateItem("Sulfuras, Hand of Ragnaros", 0, 80),
                Item.CreateItem("Sulfuras, Hand of Ragnaros", -1, 80),
                Item.CreateItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                Item.CreateItem("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                Item.CreateItem("Backstage passes to a TAFKAL80ETC concert", 5, 49),
            };

            var app = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    System.Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }

                Console.WriteLine(string.Empty);
                app.UpdateQuality();
            }
        }
    }
}
