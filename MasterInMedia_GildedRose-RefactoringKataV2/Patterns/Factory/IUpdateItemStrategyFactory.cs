using MasterInMedia_GildedRose_RefactoringKataV2.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKataV2.Patterns.Factory
{
    /// <summary>
    /// Strategy factory item update interface.
    /// </summary>
    public interface IUpdateItemStrategyFactory
    {
        /// <summary>
        /// Gets instance of specific item type.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Returns generic item type object.</returns>
        IUpdateStrategy GetInstance(Item item);
    }
}
