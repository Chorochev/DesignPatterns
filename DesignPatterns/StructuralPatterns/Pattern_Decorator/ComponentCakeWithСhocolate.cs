using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Decorator
{
    /// <summary>
    /// Дополнительная функциональность для торта.
    /// Добавление шоколада на торт.
    /// </summary>
    class ComponentCakeWithСhocolate : DecoratorCake
    {
        /// <summary>
        /// Добавление шоколада на торт.
        /// </summary>
        /// <param name="componentCake"></param>
        public ComponentCakeWithСhocolate(ComponentCake componentCake) : base(componentCake.Name + ", с шоколадом.", componentCake)
        {
        }
        /// <summary>
        /// Получение стоимости торта
        /// </summary>
        /// <returns></returns>
        public override double GetCost()
        {
            return this._componentCake.GetCost() + 3.15d;
        }
        /// <summary>
        /// Получение свойств торта
        /// </summary>
        /// <returns></returns>
        public override List<string> GetProperties()
        {
            var result = this._componentCake.GetProperties();
            result.Add("шоколад на торте");
            return result;
        }
    }
}
