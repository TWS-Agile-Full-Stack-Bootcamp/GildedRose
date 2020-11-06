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
            if (HasReachQualityUpperLimit())
            {
                Quality = Quality + 1;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0 && HasReachQualityUpperLimit())
            {
                Quality = Quality + 1;
            }
        }
    }
}
