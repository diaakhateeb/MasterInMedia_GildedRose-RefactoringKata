using MasterInMedia_GildedRose_RefactoringKata.Strategies;
using System;

namespace MasterInMedia_GildedRose_RefactoringKata.Patterns.Factory
{
    class UpdateItemStrategyFactory<T> : IUpdateItemStrategyFactory<T> where T : Item
    {
        public IUpdateStrategy<T> GetInstance(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieUpdateStrategy<T>(item);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackStagePassesUpdateStrategy<T>(item);
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItemsUpdateStratgey<T>(item);
                case "Conjured Mana Cake":
                    return new ConjuredUpdateStrategy<T>(item);
                default:
                    return new StandardItemsUpdateStrategy<T>(item);
            }
        }
    }
}
