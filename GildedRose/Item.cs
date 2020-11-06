using System;
namespace GildedRose
{
    public class Item
    {
        private const string AGED_BIRE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";

        protected Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public static Item CreateItem(string name, int sellIn, int quality)
        {
            return new Item(name, sellIn, quality);
        }

        public void Update()
        {
            switch (Name)
            {
                case AGED_BIRE:
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }

                    SellIn = SellIn - 1;

                    if (SellIn < 0 && Quality < 50)
                    {
                        Quality = Quality + 1;
                    }

                    break;
                case BACKSTAGE_PASSES:
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;

                        if (SellIn < 11)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }

                        if (SellIn < 6)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }
                    }

                    SellIn = SellIn - 1;

                    if (SellIn < 0)
                    {
                        Quality = Quality - Quality;
                    }

                    break;
                case SULFURAS:
                    break;
                default:
                    if (Quality > 0)
                    {
                        Quality = Quality - 1;
                    }

                    SellIn = SellIn - 1;

                    if (SellIn < 0 && Quality > 0)
                    {
                        Quality = Quality - 1;
                    }

                    break;
            }
        }
    }
}
