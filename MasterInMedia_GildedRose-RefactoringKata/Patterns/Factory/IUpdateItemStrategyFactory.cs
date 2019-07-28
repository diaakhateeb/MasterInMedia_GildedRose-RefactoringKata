using MasterInMedia_GildedRose_RefactoringKata.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKata.Patterns.Factory
{
    public interface IUpdateItemStrategyFactory<T> where T : Item
    {
        IUpdateStrategy<T> GetInstance(T item);
    }
}
