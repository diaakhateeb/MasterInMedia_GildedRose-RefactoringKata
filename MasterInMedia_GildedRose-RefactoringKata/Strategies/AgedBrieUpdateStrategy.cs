﻿using MasterInMedia_GildedRose_RefactoringKata.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    /// <summary>
    /// AgedBrieUpdateStrategy item class.
    /// </summary>
    /// <typeparam name="T">Item Generic type.</typeparam>
    public class AgedBrieUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;

        /// <summary>
        /// Initializes a new instance of AgedBrieUpdateStrategy class.
        /// </summary>
        /// <param name="item">Item type.</param>
        public AgedBrieUpdateStrategy(T item)
        {
            _item = item;
        }
        /// <summary>
        /// Update item method.
        /// </summary>
        public void UpdateItem()
        {
            if (_item.Quality < 50) _item.Quality++;

            _item.SellIn--;

            if (_item.SellIn < 0 && _item.Quality < 50) _item.Quality++;
        }
    }
}
