using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_FactoryMethod
{
    /// <summary>
    ///  Конкретная реализация класса "Машина" - Автобус
    /// </summary>
    class ConcreteCar_Bus : Product_Car
    {
        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public int Passengers { get; set; }
        
        public ConcreteCar_Bus(string name, string type) : base(name, type)
        {
            this.Passengers = 10;
        }
        /// <summary>
        /// Печать характеристик автобуса
        /// </summary>
        public override void PrintPoperties()
        {
            System.Console.WriteLine("Характеристики автобуса:");
            System.Console.WriteLine("   Наименование: {0}.", Name);
            System.Console.WriteLine("   Тип авто: {0}.", Type);            
            System.Console.WriteLine("   Количество пассажиров: {0}.", Passengers);
        }
    }
}
