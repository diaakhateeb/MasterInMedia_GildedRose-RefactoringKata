using MasterInMedia_GildedRose_RefactoringKata.Patterns.Factory;
using System.Collections.Generic;

namespace MasterInMedia_GildedRose_RefactoringKata
{
    public class GildedRose
    {
        IList<Item> _items;
        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            var fac = new UpdateItemStrategyFactory<Item>();

            for (var i = 0; i < _items.Count; i++)
            {
                fac.GetInstance(_items[i]).UpdateItem();
            }
        }
    }
}
