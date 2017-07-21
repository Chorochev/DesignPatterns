using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Strategy
{
    /// <summary>
    /// Класс Context хранит ссылку на объект IStrategy и связан с интерфейсом IStrategy отношением агрегации.
    /// Вызов машин
    /// </summary>
    class Context_CallingAvto
    {
        /// <summary>
        /// Стратегия
        /// </summary>
        public IStrategy strategy { get; private set; }
        /// <summary>
        /// Установка стратегии
        /// </summary>
        /// <param name="strategy">конкретная стратегия</param>
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
}
