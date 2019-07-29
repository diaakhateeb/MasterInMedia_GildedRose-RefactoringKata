using MasterInMedia_GildedRose_RefactoringKataV2.Interfaces;
using MasterInMedia_GildedRose_RefactoringKataV2.Items;
using MasterInMedia_GildedRose_RefactoringKataV2.Strategies;
using NLog;
using System;

namespace MasterInMedia_GildedRose_RefactoringKataV2.Patterns.Factory
{
    /// <summary>
    /// Creates item object class.
    /// </summary>
    public class UpdateItemStrategyFactory : IUpdateItemStrategyFactory
    {
        private readonly Logger _logger;

        public UpdateItemStrategyFactory()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Gets instance of specified item type.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Returns item type object.</returns>
        /// <exception cref="TypeInitializationException">TypeInitializationException</exception>
        /// <exception cref="TypeLoadException">TypeLoadException</exception>
        public IUpdateStrategy GetInstance(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            try
            {
                if (item is AgieBrie)
                {
                    var item2 = (AgieBrie)item;
                    return new AgedBrieUpdateStrategy(item2);
                }
                else if (item is BackStagePasses backstageItem)
                {
                    return new BackStagePassesUpdateStrategy(backstageItem);
                }
                else if (item is Conjured conjuredItem)
                {
                    return new ConjuredUpdateStrategy(conjuredItem);
                }
                else if (item is Legendary legendaryItem)
                {
                    return new LegendaryItemsUpdateStratgey(legendaryItem);
                }
                else return new StandardItemsUpdateStrategy(item);
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
