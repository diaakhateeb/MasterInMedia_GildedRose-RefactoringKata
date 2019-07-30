using MasterInMedia_GildedRose_RefactoringKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose_RefactoringKataTest
{
    [TestFixture]
    public class AgedBrieTest
    {
        [Test]
        public void QualityIncreasesByOne_SellInIsPositive()
        {
            var itemsList = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 0 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(1, itemsList[0].Quality);
        }

        [Test]
        public void QualityIncreasesByTwo_SellInIsZeroOrNegative()
        {
            var itemsList = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(2, itemsList[0].Quality);
        }

        [Test]
        public void QualityCannotBeMoreThan50()
        {
            var itemsList = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();
            Assert.AreEqual(50, itemsList[0].Quality);

            //We repeat calling UpdateQuality() to make sure that quality is still 50 as per requirements.
            app.UpdateQuality();
            Assert.AreEqual(50, itemsList[0].Quality);
        }
    }
}
