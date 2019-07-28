﻿using MasterInMedia_GildedRose_RefactoringKata.Interfaces;

namespace MasterInMedia_GildedRose_RefactoringKata.Strategies
{
    public class ConjuredUpdateStrategy<T> : IUpdateStrategy<T> where T : Item
    {
        private readonly T _item;

        public ConjuredUpdateStrategy(T item)
        {
            _item = item;
        }
        public void UpdateItem()
        {
            _item.SellIn--;

            if (_item.Quality > 0) _item.Quality--;

            if (_item.SellIn < 0)
                if (_item.Quality > 0) _item.Quality--;
        }
    }
}
