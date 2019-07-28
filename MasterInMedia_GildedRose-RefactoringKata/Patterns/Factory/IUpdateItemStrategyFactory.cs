using MasterInMedia_GildedRose_RefactoringKata.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKata.Patterns.Factory
{
    /// <summary>
    /// Strategy factory item update interface.
    /// </summary>
    /// <typeparam name="T">Generic T item type.</typeparam>
    public interface IUpdateItemStrategyFactory<T> where T : Item
    {
        /// <summary>
        /// Gets instance of T item generic type.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Returns generic item type object.</returns>
        IUpdateStrategy<T> GetInstance(T item);
    }
}
