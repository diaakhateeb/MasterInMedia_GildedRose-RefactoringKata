using MasterInMedia_GildedRose_RefactoringKata.Patterns.Factory;
using NLog;
using System;
using System.Collections.Generic;

namespace MasterInMedia_GildedRose_RefactoringKata
{
    public class GildedRose<T> where T : Item
    {
        IList<T> _items;
        private readonly Logger _logger;
        public GildedRose(IList<T> items)
        {
            _items = items;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public void UpdateQuality()
        {
            try
            {
                var fac = new UpdateItemStrategyFactory<T>();

                for (var i = 0; i < _items.Count; i++)
                {
                    var obj = fac.GetInstance(_items[i]);
                    obj?.UpdateItem();
                }
            }
            catch (TypeInitializationException typeInitExp)
            {
                _logger.Error(typeInitExp, typeInitExp.Message);
            }
            catch (TypeLoadException typeLoadExp)
            {
                _logger.Error(typeLoadExp, typeLoadExp.Message);
            }
            catch (Exception exp)
            {
                _logger.Error(exp, exp.Message);
            }
        }
    }
}
