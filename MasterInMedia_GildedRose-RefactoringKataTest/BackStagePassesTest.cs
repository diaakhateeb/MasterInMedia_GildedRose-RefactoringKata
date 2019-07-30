using MasterInMedia_GildedRose_RefactoringKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose_RefactoringKataTest
{
    [TestFixture]
    public class BackStagePassesTest
    {
        [Test]
        public void QualityIncreaseByOne_SellInGreaterThan10()
        {
            var itemsList = new List<Item> { new Item
                { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(21, itemsList[0].Quality);
        }

        [Test]
        public void QualityIncreaseByTwo_SellInBetween10And6()
        {
            var itemsList = new List<Item> { new Item
                { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(22, itemsList[0].Quality);
        }

        [Test]
        public void QualityIncreaseByTwo_SellInBetween5And0()
        {
            var itemsList = new List<Item> { new Item
                { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(23, itemsList[0].Quality);
        }

        [Test]
        public void QualityShouldBeZero_WhenSellInNegative()
        {
            var itemsList = new List<Item> { new Item
                { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(0, itemsList[0].Quality);
        }

        [Test]
        public void QualityCannotBeMoreThan50()
        {
            var itemsList = new List<Item> { new Item
                { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();
            Assert.AreEqual(50, itemsList[0].Quality);

            //We repeat calling UpdateQuality() to make sure that quality is still 50 as per requirements.
            app.UpdateQuality();
            Assert.AreEqual(50, itemsList[0].Quality);
        }
    }
}
