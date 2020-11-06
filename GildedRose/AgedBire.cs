using System;
namespace GildedRose
{
    public class AgedBire : Item
    {
        public AgedBire(int sellIn, int quality) : base("Aged Brie", sellIn, quality)
        {
        }

        public override void Update()
        {
            if (IsBelowMaxQuality())
            {
                Quality = Quality + 1;
            }

            DecreaseSellIn();

            if (SellIn < 0 && IsBelowMaxQuality())
            {
                Quality = Quality + 1;
            }
        }
    }
}
