using MasterInMedia_GildedRose_RefactoringKataV2.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKataV2.Strategies
{
    /// <summary>
    /// StandardItemsUpdateStrategy item class.
    /// </summary>
    public class StandardItemsUpdateStrategy : IUpdateStrategy
    {
        private readonly Item _item;

        /// <summary>
        /// Initializes a new instance of StandardItemsUpdateStrategy class.
        /// </summary>
        /// <param name="item">Item type.</param>
        public StandardItemsUpdateStrategy(Item item)
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
