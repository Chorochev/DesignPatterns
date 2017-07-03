using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_FactoryMethod
{
    /// <summary>
    /// Абстрактный фабричный метод, который возвращает объект Product_Car.
    /// Вызов автомобиля
    /// </summary>
    abstract class Creator_Calling
    {
        public string TypeCar { get; private set; }

        /// <summary>
        /// Вызов автомобиля
        /// </summary>
        /// <param name="type"></param>
        public Creator_Calling(string type)
        {
            TypeCar = type;      
        }

        public abstract Product_Car FactoryMethod();      
    }
}
