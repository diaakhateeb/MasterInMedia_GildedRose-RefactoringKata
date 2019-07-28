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
            if (_item.Quality > 50) return;

            _item.SellIn--;

            if (_item.SellIn < 0) _item.Quality = 0;
            else if (_item.SellIn <= 5) _item.Quality += 3;
            else if (_item.SellIn <= 10) _item.Quality += 2;
            else _item.Quality++;
        }
    }
}
