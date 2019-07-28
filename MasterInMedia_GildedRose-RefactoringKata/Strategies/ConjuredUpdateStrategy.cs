using MasterInMedia_GildedRose_RefactoringKata.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    /// <summary>
    /// ConjuredUpdateStrategy item class.
    /// </summary>
    /// <typeparam name="T">Item Generic type.</typeparam>
    public class ConjuredUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;

        /// <summary>
        /// Initializes a new instance of ConjuredUpdateStrategy class.
        /// </summary>
        /// <param name="item">Item type.</param>
        public ConjuredUpdateStrategy(T item)
        {
            _item = item;
        }
        /// <summary>
        /// Update item method.
        /// </summary>
        public void UpdateItem()
        {
            _item.SellIn--;

            if (_item.Quality > 0) _item.Quality--;

            //if (_item.SellIn < 0)
            //    if (_item.Quality > 0) _item.Quality--;

            if (_item.SellIn < 0 && _item.Quality > 0) _item.Quality--;
        }
    }
}
