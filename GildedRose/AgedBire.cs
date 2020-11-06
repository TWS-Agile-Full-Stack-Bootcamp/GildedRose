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
                IncreaseQuality();
            }

            DecreaseSellIn();

            if (IsSellInExpired() && IsBelowMaxQuality())
            {
                IncreaseQuality();
            }
        }
    }
}
