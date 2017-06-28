using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_AbstractFactory
{
    /// <summary>
    /// Класс использует класс фабрики для создания объектов, и никак не зависит от их конкретных реализаций.
    /// </summary>
    class Client
    {
        /// <summary>
        /// Продукт "A"
        /// </summary>
        private AbstractProductA _abstractProductA;
        /// <summary>
        /// Продукт "B"
        /// </summary>
        private AbstractProductB _abstractProductB;
        /// <summary>
        /// Создаем клиента с конкретной фабрикой
        /// </summary>
        /// <param name="factory"></param>
        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }
        /// <summary>
        /// Информация о продукте "A"
        /// </summary>
        public void InfoProductA()
        {
            Console.WriteLine("GetNumberA() => {0}", _abstractProductA.GetNumberA());
            Console.WriteLine("GetWeightA() => {0}", _abstractProductA.GetWeightA());
        }
        /// <summary>
        /// Информация о продукте "B"
        /// </summary>
        public void InfoProductB()
        {
            Console.WriteLine("GetNumberB() => {0}", _abstractProductB.GetNumberB());
            Console.WriteLine("GetSizeB() => {0}", _abstractProductB.GetSizeB());
            Console.WriteLine("GetTypeB() => {0}", _abstractProductB.GetTypeB());
        }
    }
}
