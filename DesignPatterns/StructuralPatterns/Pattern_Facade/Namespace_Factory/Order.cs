using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Facade.Namespace_Factory
{
    /// <summary>
    /// Это компонент сложной подсистемы, с которой должен взаимодействовать клиент.    
    /// В данном случае этот класс описывает "Заказ".
    /// </summary>
    internal class Order
    {
        #region params
        /// <summary>
        /// Наименование заказа
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Статус закала - Открыт/Закрыт
        /// </summary>
        public bool IsOpen { get; private set; }
        /// <summary>
        /// Стоимость заказа
        /// </summary>
        public double Cost { get; private set; }
        #endregion

        /// <summary>
        /// Заказ - это компонент сложной подсистемы, с которой должен взаимодействовать клиент.
        /// </summary>
        /// <param name="name">Наименование заказа</param>
        /// <param name="cost">Стоимость заказа</param>
        public Order(string name = null, double cost = 0d)
        {
            SetNameOrder(name);
            SetCost(cost);
        }
        #region public Open, Close, SetCost
        /// <summary>
        /// Открытие заказа
        /// </summary>
        public void Open()
        {
            IsOpen = true;
            PrintInfo("Открытие.");
        }
        /// <summary>
        /// Закрытие заказа
        /// </summary>
        public void Close()
        {
            IsOpen = false;
            PrintInfo("Закрытие.");
        }
        /// <summary>
        /// Установка стоимости заказа
        /// </summary>
        /// <param name="cost"></param>
        public void SetCost(double cost)
        {
            Cost = cost;
            PrintInfo("Установленна стоимость заказа = {0:0.00}.", Cost);
        }
        #endregion

        #region private SetNameOrder, PrintInfo
        /// <summary>
        /// Установка имени заказа
        /// </summary>
        private void SetNameOrder(string name = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                string number = (new Guid()).ToString().Take(4).ToString();
                Name = string.Format("Заказ №{0}", number);
            }
            else
                Name = name;
        }
        /// <summary>
        /// Печать сообщений
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <param name="args">аргументы</param>
        private void PrintInfo(string message, params object[] args)
        {
            System.Console.WriteLine("Заказ {0}: ", Name);
            System.Console.Write("Событие: ");
            System.Console.WriteLine(message, args);
        }
        #endregion
    }
}
