using MasterInMedia_GildedRose_RefactoringKata.Patterns.Factory;
using System.Collections.Generic;

namespace MasterInMedia_GildedRose_RefactoringKata
{
    public class GildedRose<T> where T : Item
    {
        IList<T> _items;
        public GildedRose(IList<T> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            var fac = new UpdateItemStrategyFactory<T>();

            for (var i = 0; i < _items.Count; i++)
            {
                var obj = fac.GetInstance(_items[i]);
                obj?.UpdateItem();
            }
        }
    }
}
