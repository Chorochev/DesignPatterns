using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Decorator
{
    /// <summary>
    /// Дополнительная функциональность для торта.
    /// Добавление свечек на торт.
    /// </summary>
    class ComponentCakeWithCandles : DecoratorCake
    {
        /// <summary>
        /// Добавление свечек на торт.
        /// </summary>
        /// <param name="componentCake"></param>
        public ComponentCakeWithCandles(ComponentCake componentCake) : base(componentCake.Name + ", со свечками.", componentCake)
        {
        }
        /// <summary>
        /// Получение стоимости торта
        /// </summary>
        /// <returns></returns>
        public override double GetCost()
        {
            return this._componentCake.GetCost() + 1.25d;
        }
        /// <summary>
        /// Получение свойств торта
        /// </summary>
        /// <returns></returns>
        public override List<string> GetProperties()
        {
            var result = this._componentCake.GetProperties();
            result.Add("свечки на торт");
            return result;
        }        
    }
}
