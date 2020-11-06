using System;
namespace GildedRose
{
    public class Item
    {
        private const string AGED_BIRE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            if (this.Name == AGED_BIRE)
            {
                if (this.Quality < 50)
                {
                    this.Quality = this.Quality + 1;
                }

                this.SellIn = this.SellIn - 1;

                if (this.SellIn < 0 && this.Quality < 50)
                {
                    this.Quality = this.Quality + 1;
                }
            }
            else if (this.Name == BACKSTAGE_PASSES)
            {
                if (this.Quality < 50)
                {
                    this.Quality = this.Quality + 1;

                    if (this.SellIn < 11)
                    {
                        if (this.Quality < 50)
                        {
                            this.Quality = this.Quality + 1;
                        }
                    }

                    if (this.SellIn < 6)
                    {
                        if (this.Quality < 50)
                        {
                            this.Quality = this.Quality + 1;
                        }
                    }
                }

                this.SellIn = this.SellIn - 1;

                if (this.SellIn < 0)
                {
                    this.Quality = this.Quality - this.Quality;
                }
            }
            else if (this.Name == SULFURAS)
            {
            }
            else
            {
                if (this.Quality > 0)
                {
                    this.Quality = this.Quality - 1;
                }

                this.SellIn = this.SellIn - 1;

                if (this.SellIn < 0 && this.Quality > 0)
                {
                    this.Quality = this.Quality - 1;
                }
            }
        }
    }
}
