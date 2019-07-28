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

            if (_item.Quality >= 50) return;

            if (_item.SellIn < 0) _item.Quality = 0;
            else if (_item.SellIn < 6) _item.Quality += 3;
            else if (_item.SellIn < 11) _item.Quality += 2;
            else _item.Quality++;

            //if (_item.Quality < 50) _item.Quality++;

            //if (_item.SellIn < 10)
            //{
            //    if (_item.Quality < 50) _item.Quality++;
            //}
            //if (_item.SellIn < 5)
            //{
            //    if (_item.Quality < 50) _item.Quality++;
            //}
            //if (_item.SellIn < 0)
            //{
            //    _item.Quality = 0;
            //}
        }
    }
}
