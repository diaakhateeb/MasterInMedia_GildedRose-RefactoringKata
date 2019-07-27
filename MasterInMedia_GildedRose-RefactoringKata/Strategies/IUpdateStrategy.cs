namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    public interface IUpdateStrategy<in T> where T : Item
    {
        void UpdateItem();
    }
}
