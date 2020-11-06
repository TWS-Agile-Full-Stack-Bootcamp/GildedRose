using System.Collections.Generic;
using System.Linq;

namespace GildedRose
{
    public class GildedRose
    {
        private IList<Item> items;
        public GildedRose(IList<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            items.ToList().ForEach(item => item.Update());
        }
    }
}
