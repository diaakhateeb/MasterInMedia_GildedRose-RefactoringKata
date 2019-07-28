namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    public class AgedBrieUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;
        //readonly IItemCalculation<T> _itemCalc;

        public AgedBrieUpdateStrategy(T item)
        {
            _item = item;
            //_itemCalc = itemCalc;
        }
        public void UpdateItem()
        {
            //if (_item.Quality >= 50) return;

            //_item.SellIn--;
            //_item.Quality++;

            if (_item.Quality < 50) _item.Quality += 1;

            _item.SellIn -= 1;

            if (_item.SellIn < 0)
                if (_item.Quality < 50) _item.Quality += 1;
        }
    }
}
