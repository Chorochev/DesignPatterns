using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Facade
{
    /// <summary>
    /// Facade - непосредственно фасад, который предоставляет интерфейс клиенту для работы с компонентами.
    /// </summary>
    public static class Facade
    {
        /// <summary>
        /// Доставка 10000 средних кирпичей на стройплощадку №1.
        /// </summary>
        public static void Operation1()
        {
            // Создаем заказ
            Namespace_Factory.Order order = new Namespace_Factory.Order("Заказ на перевозку кирпичей");
            order.Open();
            order.SetCost(50000);

            // Транспортировка
            Namespace_Factory.Transportation transportation = new Namespace_Factory.Transportation("Гараж", "Завод по производству кирпичей");            
            transportation.ToGoByCarToTheStartPoint();
            transportation.TheCarCameToTheStartPoint();
            transportation.ToGoByCarToTheEndPoint();
            transportation.TheCarCameToTheEndPoint();
            // Создаем кирпичи 
            Namespace_Factory.PlantForTheProductionOfBricks briks = new Namespace_Factory.PlantForTheProductionOfBricks();
            briks.Create(10000, "Средний");

            // Транспортировка
            Namespace_Factory.Transportation transportation2 = new Namespace_Factory.Transportation("Завод по производству кирпичей", "Стройплощадка №1");
            transportation2.BootingTheMachine();
            transportation2.ToGoByCarToTheEndPoint();
            transportation2.TheCarCameToTheEndPoint();
            transportation2.UnloadingMachine();

            // Закрываем заказ
            order.Close();
        }
    }
}
