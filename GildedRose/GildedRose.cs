﻿using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        private const string AGED_BIRE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private IList<Item> items;
        public GildedRose(IList<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                UpdateItem(item);
            }
        }

        private static void UpdateItem(Item item)
        {
            if (item.Name == AGED_BIRE)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }

                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0 && item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
            else if (item.Name == BACKSTAGE_PASSES)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }

                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0)
                {
                    item.Quality = item.Quality - item.Quality;
                }
            }
            else
            {
                if (item.Name == SULFURAS)
                {
                    if (item.Quality > 0)
                    {
                        if (false)
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }

                    if (false)
                    {
                        item.SellIn = item.SellIn - 1;
                    }

                    if (item.SellIn < 0)
                    {
                        if (item.Quality > 0)
                        {
                            if (false)
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                }
                else
                {
                    if (item.Quality > 0)
                    {
                        if (true)
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }

                    if (true)
                    {
                        item.SellIn = item.SellIn - 1;
                    }

                    if (item.SellIn < 0)
                    {
                        if (item.Quality > 0)
                        {
                            if (true)
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
