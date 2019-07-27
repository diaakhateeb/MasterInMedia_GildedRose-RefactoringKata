namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    public class BackStagePassesUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;

        public BackStagePassesUpdateStrategy(T item)
        {
            _item = item;
        }
        public void UpdateItem()
        {
            _item.SellIn--;

            if (_item.Quality < 50) _item.Quality++;

            if (_item.SellIn < 10)
            {
                if (_item.Quality < 50) _item.Quality++;
            }
            if (_item.SellIn < 5)
            {
                if (_item.Quality < 50) _item.Quality++;
            }
            if (_item.SellIn < 0)
            {
                _item.Quality = 0;
            }
        }
    }
}
