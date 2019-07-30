using MasterInMedia_GildedRose_RefactoringKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose_RefactoringKataTest
{
    [TestFixture]
    public class LegendaryTest
    {
        [Test]
        public void QualityIsAlways80()
        {
            var itemsList = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(80, itemsList[0].Quality);
        }

        [Test]
        public void SellInNotDecreased()
        {
            var itemsList = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(0, itemsList[0].SellIn);
        }
    }
}
