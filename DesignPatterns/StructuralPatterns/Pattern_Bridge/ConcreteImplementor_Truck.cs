using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Bridge
{
    /// <summary>
    /// Конкретная реализация, которая унаследована от Implementor.
    /// В данном случае реализация класса который представляет грузовой автомобиль
    /// </summary>
    class ConcreteImplementor_Truck : Implementor_ICar
    {
        /// <summary>
        /// Тоннаж
        /// </summary>
        public int Tonnage { get; private set; }
        /// <summary>
        /// Средняя скорость
        /// </summary>
        public int AVGSpeed { get; private set; }
        /// <summary>
        /// Грузовик
        /// </summary>
        /// <param name="Tonnage">тонаж</param>
        /// <param name="AVGSpeed">средняя скорость</param>
        public ConcreteImplementor_Truck(int Tonnage, int AVGSpeed)
        {
            this.Tonnage = Tonnage;
            this.AVGSpeed = AVGSpeed;
        }
        /// <summary>
        /// Вызов грузовика
        /// </summary>
        public override void Calling()
        {
            System.Console.WriteLine("Вызван грузовик.");
            System.Console.WriteLine("Тоннаж : {0}.", Tonnage);
            System.Console.WriteLine("Средняя скорость : {0}.", AVGSpeed);
        }
        /// <summary>
        /// Загрузка груза
        /// </summary>
        public override void Loading()
        {
            System.Console.WriteLine("Загрузка груза.");
        }
        /// <summary>
        /// Выгрузка груза.
        /// </summary>
        public override void Unloading()
        {
            System.Console.WriteLine("Выгрузка груза.");
        }
    }
}
