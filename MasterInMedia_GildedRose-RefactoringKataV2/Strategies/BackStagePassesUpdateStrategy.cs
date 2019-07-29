using MasterInMedia_GildedRose_RefactoringKataV2.Interfaces;
using MasterInMedia_GildedRose_RefactoringKataV2.Items;

namespace MasterInMedia_GildedRose_RefactoringKataV2.Strategies
{
    /// <summary>
    /// BackStagePassesUpdateStrategy item class.
    /// </summary>
    public class BackStagePassesUpdateStrategy : IUpdateStrategy
    {
        private readonly Item _item;
        /// <summary>
        /// Initializes a new instance of BackStagePassesUpdateStrategy class.
        /// </summary>
        /// <param name="item">Item type.</param>
        public BackStagePassesUpdateStrategy(BackStagePasses item)
        {
            _item = item;
        }
        /// <summary>
        /// Update item method.
        /// </summary>
        public void UpdateItem()
        {
            if (_item.SellIn > 0 && _item.Quality < 50) _item.Quality++;

            if (_item.SellIn <= 10 && _item.Quality < 50) _item.Quality++;

            if (_item.SellIn <= 5 && _item.Quality < 50) _item.Quality++;

            _item.SellIn--;

            if (_item.SellIn < 0) _item.Quality = 0;
        }
    }
}
