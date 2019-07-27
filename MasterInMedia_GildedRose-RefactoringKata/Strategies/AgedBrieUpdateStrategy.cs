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
            _item.SellIn--;
            if (_item.Quality < 50) _item.Quality++;
        }
    }
}
