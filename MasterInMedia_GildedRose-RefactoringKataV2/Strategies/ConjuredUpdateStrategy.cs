using MasterInMedia_GildedRose_RefactoringKataV2.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKataV2.Strategies
{
    /// <summary>
    /// ConjuredUpdateStrategy item class.
    /// </summary>
    public class ConjuredUpdateStrategy : IUpdateStrategy
    {
        private readonly Item _item;

        /// <summary>
        /// Initializes a new instance of ConjuredUpdateStrategy class.
        /// </summary>
        /// <param name="item">Item type.</param>
        public ConjuredUpdateStrategy(Item item)
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

            if (_item.SellIn < 0 && _item.Quality > 0) _item.Quality--;
        }
    }
}
