using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Bridge
{
    /// <summary>
    /// Конкретная реализация, которая унаследована от Implementor.
    /// В данном случае реализация класса который представляет легковой автомобиль
    /// </summary>
    class ConcreteImplementor_MotorCar : Implementor_ICar
    {
        /// <summary>
        /// количество посадочных мест
        /// </summary>
        public int TheNumberOfSeats { get; private set; }
        /// <summary>
        /// Средняя скорость
        /// </summary>
        public int AVGSpeed { get; private set; }
        /// <summary>
        /// Легковой автомобиль
        /// </summary>
        /// <param name="TheNumberOfSeats">количество посадочных мест</param>
        /// <param name="AVGSpeed">средняя скорость</param>
        public ConcreteImplementor_MotorCar(int TheNumberOfSeats, int AVGSpeed)
        {
            this.TheNumberOfSeats = TheNumberOfSeats;
            this.AVGSpeed = AVGSpeed;
        }
        /// <summary>
        /// Вызов легкового автомобиля
        /// </summary>
        public override void Calling()
        {
            System.Console.WriteLine("Вызван легковой автомобиль.");
            System.Console.WriteLine("Количество посадочных мест : {0}.", TheNumberOfSeats);
            System.Console.WriteLine("Средняя скорость : {0}.", AVGSpeed);
        }
        /// <summary>
        /// Загрузка пассажиров
        /// </summary>
        public override void Loading()
        {
            System.Console.WriteLine("Загрузка пассажиров.");
        }
        /// <summary>
        /// Выгрузка пассажиров.
        /// </summary>
        public override void Unloading()
        {
            System.Console.WriteLine("Выгрузка пассажиров.");
        }
    }
}
