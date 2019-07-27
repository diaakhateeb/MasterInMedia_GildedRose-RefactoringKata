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
            _item.SellIn = _item.SellIn;
            _item.Quality = _item.Quality;
        }
    }
}
