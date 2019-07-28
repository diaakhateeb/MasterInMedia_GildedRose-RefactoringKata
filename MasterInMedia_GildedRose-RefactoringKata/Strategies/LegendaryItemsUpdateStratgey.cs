using MasterInMedia_GildedRose_RefactoringKata.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    /// <summary>
    /// LegendaryItemsUpdateStratgey item class.
    /// </summary>
    /// <typeparam name="T">Item Generic type.</typeparam>
    public class LegendaryItemsUpdateStratgey<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;
        /// <summary>
        /// Initializes a new instance of LegendaryItemsUpdateStratgey class.
        /// </summary>
        /// <param name="item">Item type.</param>
        public LegendaryItemsUpdateStratgey(T item)
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
