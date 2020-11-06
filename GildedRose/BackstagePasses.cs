using System;
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

                if (SellIn < 11)
                {
                    if (IsBelowMaxQuality())
                    {
                        IncreaseQuality();
                    }
                }

                if (SellIn < 6)
                {
                    if (IsBelowMaxQuality())
                    {
                        IncreaseQuality();
                    }
                }
            }

            DecreaseSellIn();

            if (SellIn < 0)
            {
                Quality = Quality - Quality;
            }
        }
    }
}
