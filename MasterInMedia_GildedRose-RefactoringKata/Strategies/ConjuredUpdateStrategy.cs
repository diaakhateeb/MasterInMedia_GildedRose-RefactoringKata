namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    public class ConjuredUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;

        public ConjuredUpdateStrategy(T item)
        {
            _item = item;
        }
        public void UpdateItem()
        {
            _item.Quality -= 2;
            if (_item.SellIn > 0) _item.SellIn--;
            else if (_item.SellIn <= 0) _item.Quality -= 2;
        }
    }
}
