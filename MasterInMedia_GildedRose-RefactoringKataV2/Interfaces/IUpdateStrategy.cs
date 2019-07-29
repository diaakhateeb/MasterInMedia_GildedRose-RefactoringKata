namespace MasterInMedia_GildedRose_RefactoringKataV2.Interfaces
{
    /// <summary>
    /// Updates Strategy interface that exposes Update item method.
    /// </summary>
    /// <typeparam name="T">Generic item type.</typeparam>
    public interface IUpdateStrategy
    {
        /// <summary>
        /// Update item method.
        /// </summary>
        void UpdateItem();
    }
}
