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
                switch (item)
                {
                    case AgieBrie agieBrieItem:
                        return new AgedBrieUpdateStrategy(agieBrieItem);
                    case BackStagePasses backstageItem:
                        return new BackStagePassesUpdateStrategy(backstageItem);
                    case Conjured conjuredItem:
                        return new ConjuredUpdateStrategy(conjuredItem);
                    case Legendary legendaryItem:
                        return new LegendaryItemsUpdateStratgey(legendaryItem);
                    default:
                        return new StandardItemsUpdateStrategy(item);
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
