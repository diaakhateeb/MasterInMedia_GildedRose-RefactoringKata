using MasterInMedia_GildedRose_RefactoringKata.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    public class LegendaryItemsUpdateStratgey<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;
        public LegendaryItemsUpdateStratgey(T item)
        {
            _item = item;
        }
        public void UpdateItem()
        {

        }
    }
}
