using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Facade.Namespace_Factory
{
    /// <summary>
    /// Это компонент сложной подсистемы, с которой должен взаимодействовать клиент.    
    /// В данном случае этот класс описывает "Транспортировку грузов".
    /// </summary>
    internal class Transportation
    {
        /// <summary>
        /// Точка отправления
        /// </summary>
        public string StartPoint { get; private set; }
        /// <summary>
        /// Точка назначения.
        /// </summary>
        public string EndPoint { get; private set; }
        /// <summary>
        /// Признак транспортировки груза.
        /// </summary>
        public bool IsTransportation { get; private set; }
        /// <summary>
        /// Транспортировка грузов.
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        public Transportation(string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            IsTransportation = false;
        }
        /// <summary>
        /// Машина выехала в начальный пункт.
        /// </summary>
        public void ToGoByCarToTheStartPoint()
        {
            PrintInfo("Машина выехала в начальный пункт.");
        }
        /// <summary>
        /// Машина выехала в конечный пункт.
        /// </summary>
        public void ToGoByCarToTheEndPoint()
        {
            PrintInfo("Машина выехала в конечный пункт.");
        }
        /// <summary>
        /// Машина приехала в начальный пункт.
        /// </summary>
        public void TheCarCameToTheStartPoint()
        {
            PrintInfo("Машина приехала в начальный пункт.");
        }

        /// <summary>
        /// Машина приехала в конечный пункт.
        /// </summary>
        public void TheCarCameToTheEndPoint()
        {
            PrintInfo("Машина приехала в конечный пункт.");
        }
        /// <summary>
        /// Загрузка машины.
        /// </summary>
        public void BootingTheMachine()
        {
            IsTransportation = true;
            PrintInfo("Загрузка машины.");
        }
        /// <summary>
        /// Разгрузка машины.
        /// </summary>
        public void UnloadingMachine()
        {
            IsTransportation = false;
            PrintInfo("Разгрузка машины.");
        }

        /// <summary>
        /// Печать сообщений.
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <param name="args">аргументы</param>
        private void PrintInfo(string message, params object[] args)
        {
            string tr = IsTransportation ? "Транспортировка груза" : "Переезд машины";
            System.Console.WriteLine("{0} из пунтка '{1}' в '{2}'.", tr, StartPoint, EndPoint);
            System.Console.Write("Событие: ");
            System.Console.WriteLine(message, args);
        }
    }
}
