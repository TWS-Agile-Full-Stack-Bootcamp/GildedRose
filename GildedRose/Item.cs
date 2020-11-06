﻿using System;
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
            switch (name)
            {
                case AGED_BIRE: return new AgedBire(sellIn, quality);
                case BACKSTAGE_PASSES: return new BackstagePasses(sellIn, quality);
                case SULFURAS: return new Sulfuras(sellIn, quality);
                default: return new Item(name, sellIn, quality);
            }
        }

        public virtual void Update()
        {
            if (IsOverMinQuality())
            {
                Quality = Quality - 1;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0 && IsOverMinQuality())
            {
                Quality = Quality - 1;
            }
        }

        protected bool IsOverMinQuality()
        {
            return Quality > 0;
        }

        protected bool IsBelowMaxQuality()
        {
            return Quality < 50;
        }
    }
}
