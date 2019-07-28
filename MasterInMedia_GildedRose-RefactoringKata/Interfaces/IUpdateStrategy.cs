namespace MasterInMedia_GildedRose_RefactoringKata.Interfaces
{
    /// <summary>
    /// Updates Strategy interface that exposes Update item method.
    /// </summary>
    /// <typeparam name="T">Generic item type.</typeparam>
    public interface IUpdateStrategy<in T> where T : Item
    {
        /// <summary>
        /// Update item method.
        /// </summary>
        void UpdateItem();
    }
}
