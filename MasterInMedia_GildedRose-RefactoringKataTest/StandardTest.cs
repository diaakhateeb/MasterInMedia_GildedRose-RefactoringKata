using MasterInMedia_GildedRose_RefactoringKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose_RefactoringKataTest
{
    [TestFixture]
    public class StandardTest
    {
        [Test]
        public void DegradeQualityByOne_SellInIsPositive()
        {
            var itemsList = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(19, itemsList[0].Quality);
        }

        [Test]
        public void DegradeSellInByOne_SellInIsPositive()
        {
            var itemsList = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(9, itemsList[0].SellIn);
        }

        [Test]
        public void QualityDegradesTwiceAsFast_SellInIsNegative()
        {
            var itemsList = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(18, itemsList[0].Quality);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            var itemsList = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0 } };
            var app = new GildedRose<Item>(itemsList);

            app.UpdateQuality();

            Assert.AreEqual(0, itemsList[0].Quality);
        }
    }
}
