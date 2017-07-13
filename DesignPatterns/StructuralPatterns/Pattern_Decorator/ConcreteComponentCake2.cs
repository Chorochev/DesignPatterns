using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Decorator
{
    /// <summary>
    /// ConcreteComponent - конкретный компонент определяющий объект, на 
    /// который возлагаются дополнительные обязанности.
    /// В данном случае это - торт Медовик.
    /// </summary>
    class ConcreteComponentCake2 : ComponentCake
    {
        /// <summary>
        /// торт Медовик.
        /// </summary>
        public ConcreteComponentCake2() : base("Медовик")
        {
        }
        /// <summary>
        /// Получение стоимости торта "Медовик"
        /// </summary>
        /// <returns></returns>
        public override double GetCost()
        {
            return 5.20d;
        }
        /// <summary>
        /// Получение свойств торта
        /// </summary>
        /// <returns></returns>
        public override List<string> GetProperties()
        {
            return new List<string>() { "3 коржа.", "Диаметр 30см." };
        }
    }
}
