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
            for (var i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == "Aged Brie")
                {
                    //var agedBrie = new AgedBrie(new AgedBrieChecks());
                    //agedBrie.UpdateItem(_items[i]);
                }
            }
        }
    }
}
