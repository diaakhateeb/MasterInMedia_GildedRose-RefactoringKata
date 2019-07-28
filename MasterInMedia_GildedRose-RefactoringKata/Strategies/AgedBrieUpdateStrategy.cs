namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    public class AgedBrieUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;

        public AgedBrieUpdateStrategy(T item)
        {
            _item = item;
        }
        public void UpdateItem()
        {
            if (_item.Quality < 50) _item.Quality++;

            _item.SellIn--;

            if (_item.SellIn < 0)
                if (_item.Quality < 50) _item.Quality++;
        }
    }
}
