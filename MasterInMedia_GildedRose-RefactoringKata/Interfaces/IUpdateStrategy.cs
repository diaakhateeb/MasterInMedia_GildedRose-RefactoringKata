namespace MasterInMedia_GildedRose_RefactoringKata.Interfaces
{
    public interface IUpdateStrategy<in T> where T : Item
    {
        void UpdateItem();
    }
}
