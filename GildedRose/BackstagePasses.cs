﻿using System;
namespace GildedRose
{
    public class BackstagePasses : Item
    {
        public BackstagePasses(int sellIn, int quality) : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality)
        {
        }

        public override void Update()
        {
            if (IsBelowMaxQuality())
            {
                IncreaseQuality();

                if (IsSellInNoGreaterThan(10))
                {
                    if (IsBelowMaxQuality())
                    {
                        IncreaseQuality();
                    }
                }

                if (IsSellInNoGreaterThan(5))
                {
                    if (IsBelowMaxQuality())
                    {
                        IncreaseQuality();
                    }
                }
            }

            DecreaseSellIn();

            if (IsSellInExpired())
            {
                Quality = Quality - Quality;
            }
        }
    }
}
