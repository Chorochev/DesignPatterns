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
    /// В данном случае это - торт Напалеон.
    /// </summary>
    class ConcreteComponentCake1 : ComponentCake
    {
        /// <summary>
        ///  торт Напалеон.
        /// </summary>
        public ConcreteComponentCake1() : base("Наполеон")
        {
        }

        /// <summary>
        /// Получение стоимости торта "Наполеон"
        /// </summary>
        /// <returns></returns>
        public override double GetCost()
        {
            return 3.50d;
        }
        /// <summary>
        /// Получение свойств торта
        /// </summary>
        /// <returns></returns>
        public override List<string> GetProperties()
        {
            return new List<string>() { "10 коржей." };
        }
    }
}
