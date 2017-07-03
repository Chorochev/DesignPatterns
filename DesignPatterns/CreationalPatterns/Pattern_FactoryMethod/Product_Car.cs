using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_FactoryMethod
{
    /// <summary>
    /// Интерфейс класса "Машина"
    /// </summary>
    abstract class Product_Car
    {
        /// <summary>
        /// Наименование авто
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Тип авто
        /// </summary>
        public string Type { get; private set; }
        
        public Product_Car(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        /// <summary>
        /// Печать характеристик авто
        /// </summary>
        public abstract void PrintPoperties();        
    }



}
