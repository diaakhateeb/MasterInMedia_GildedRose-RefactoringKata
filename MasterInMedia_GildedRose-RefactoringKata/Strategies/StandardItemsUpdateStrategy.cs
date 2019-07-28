namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    public class StandardItemsUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;
        public StandardItemsUpdateStrategy(T item)
        {
            _item = item;
        }
        public void UpdateItem()
        {
            if (_item.Quality > 0)
            {
                _item.Quality--;
            }

            // Decrease SellIn Date
            _item.SellIn--;

            if (_item.SellIn < 0)
            {
                if (_item.Quality > 0)
                {
                    _item.Quality--;
                }
            }

            //_item.SellIn--;

            //if (_item.Quality <= 0) return;

            //if (_item.SellIn < 0) _item.Quality = -2;
            //else _item.Quality--;

            ////if (_item.Quality > 0) _item.Quality--;

            ////if (_item.SellIn < 0 && _item.Quality > 0) _item.Quality--;
        }
    }
}
