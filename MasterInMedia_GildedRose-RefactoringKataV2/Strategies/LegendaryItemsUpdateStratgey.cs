using MasterInMedia_GildedRose_RefactoringKataV2.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKataV2.Strategies
{
    /// <summary>
    /// LegendaryItemsUpdateStratgey item class.
    /// </summary>
    public class LegendaryItemsUpdateStratgey : IUpdateStrategy
    {
        private readonly Item _item;
        /// <summary>
        /// Initializes a new instance of LegendaryItemsUpdateStratgey class.
        /// </summary>
        /// <param name="item">Item type.</param>
        public LegendaryItemsUpdateStratgey(Item item)
        {
            _item = item;
        }

        /// <summary>
        /// Update item method.
        /// </summary>
        public void UpdateItem()
        {

        }
    }
}
