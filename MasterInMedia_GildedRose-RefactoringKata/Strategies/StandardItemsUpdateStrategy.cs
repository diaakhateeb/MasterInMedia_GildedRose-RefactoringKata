using MasterInMedia_GildedRose_RefactoringKata.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    /// <summary>
    /// StandardItemsUpdateStrategy item class.
    /// </summary>
    /// <typeparam name="T">Item Generic type.</typeparam>
    public class StandardItemsUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;

        /// <summary>
        /// Initializes a new instance of StandardItemsUpdateStrategy class.
        /// </summary>
        /// <param name="item">Item type.</param>
        public StandardItemsUpdateStrategy(T item)
        {
            _item = item;
        }

        /// <summary>
        /// Update item method.
        /// </summary>
        public void UpdateItem()
        {
            if (_item.Quality > 0) _item.Quality--;

            _item.SellIn--;

            if (_item.SellIn < 0 && _item.Quality > 0) _item.Quality--;
        }
    }
}
