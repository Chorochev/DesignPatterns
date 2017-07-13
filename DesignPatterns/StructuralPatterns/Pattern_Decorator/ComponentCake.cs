using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Decorator
{
    /// <summary>
    /// Component - компонент определяет интерфейс для объектов, на которые могут 
    /// быть динамически возложены дополнительные обязанности;
    /// В данном случае компонентом будет - Торт.
    /// </summary>
    abstract class ComponentCake
    {
        /// <summary>
        /// Наименование торта
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Получение стоимости торта
        /// </summary>
        public abstract double GetCost();
        /// <summary>
        /// Получение свойств торта
        /// </summary>
        /// <returns></returns>
        public abstract List<string> GetProperties();        
        
        public ComponentCake(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Иформация о торте
        /// </summary>
        public void InfoCake()
        {
            System.Console.WriteLine("Торт - '{0}'", Name);
            System.Console.WriteLine("Описание:");
            foreach (var item in GetProperties())
            {
                System.Console.WriteLine("- {0}", item);
            }
            System.Console.WriteLine("Цена : {0}", GetCost());
        }
    }
}
