namespace MasterInMedia_GildedRose_RefactoringKata
{
    /// <summary>
    /// Item Class.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Item Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Number of days where item must be sold in.
        /// </summary>
        public int SellIn { get; set; }
        /// <summary>
        /// Value of item (how much item is healthy).
        /// </summary>
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }
    }
}
