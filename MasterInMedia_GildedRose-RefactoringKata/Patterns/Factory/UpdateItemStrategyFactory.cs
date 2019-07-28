using MasterInMedia_GildedRose_RefactoringKata.Interfaces;
using MasterInMedia_GildedRose_RefactoringKata.Strategies;
using NLog;
using System;

namespace MasterInMedia_GildedRose_RefactoringKata.Patterns.Factory
{
    /// <summary>
    /// Creates item object class.
    /// </summary>
    /// <typeparam name="T">Generic T item type.</typeparam>
    public class UpdateItemStrategyFactory<T> : IUpdateItemStrategyFactory<T> where T : Item
    {
        private readonly Logger _logger;

        public UpdateItemStrategyFactory()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Gets instance of T item generic type.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Returns generic item type object.</returns>
        /// <exception cref="TypeInitializationException">TypeInitializationException</exception>
        /// <exception cref="TypeLoadException">TypeLoadException</exception>
        public IUpdateStrategy<T> GetInstance(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            try
            {
                switch (item.Name)
                {
                    case "Aged Brie":
                        return new AgedBrieUpdateStrategy<T>(item);
                    case "Backstage passes to a TAFKAL80ETC concert":
                        return new BackStagePassesUpdateStrategy<T>(item);
                    case "Sulfuras, Hand of Ragnaros":
                        return new LegendaryItemsUpdateStratgey<T>(item);
                    case "Conjured Mana Cake":
                        return new ConjuredUpdateStrategy<T>(item);
                    default:
                        return new StandardItemsUpdateStrategy<T>(item);
                }
            }
            catch (TypeInitializationException typeInitExp)
            {
                _logger.Error(typeInitExp, typeInitExp.Message);
                return null;
            }
            catch (TypeLoadException typeLoadExp)
            {
                _logger.Error(typeLoadExp, typeLoadExp.Message);
                return null;
            }
            catch (Exception exp)
            {
                _logger.Error(exp, exp.Message);
                return null;
            }
        }
    }
}
