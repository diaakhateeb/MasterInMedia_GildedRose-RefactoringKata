using MasterInMedia_GildedRose_RefactoringKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose_RefactoringKataTest
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}
