using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_FactoryMethod
{
    /// <summary>
    /// Конкретная реализация класса "Машина" - Грузовик
    /// </summary>
    class ConcreteCar_TruckTransport : Product_Car
    {
        /// <summary>
        /// Грузоподъемность
        /// </summary>
        public int Tonnage { get; private set; }
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { get; private set; }

        public ConcreteCar_TruckTransport(string name, string type) : base(name, type)
        {
            Tonnage = 123;
            MaxSpeed = 70;
        }
        /// <summary>
        /// Печать характеристик грузового авто
        /// </summary>
        public override void PrintPoperties()
        {
            System.Console.WriteLine("Характеристики грузовика:");
            System.Console.WriteLine("   Наименование: {0}.", Name);
            System.Console.WriteLine("   Тип авто: {0}.", Type);
            System.Console.WriteLine("   Грузоподъемность: {0}.", Tonnage);
            System.Console.WriteLine("   Максимальная скорость: {0}.", MaxSpeed);
        }
    }
}
