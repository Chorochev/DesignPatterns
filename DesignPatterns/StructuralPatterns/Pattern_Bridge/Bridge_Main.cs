using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Bridge
{
    public static class Bridge_Main
    {
        public static void Go()
        {
            // Создаем компанию
            Abctraction_Transportation company;
            company = new RefinedAbstraction_Transportation(100.7d);
            // Допустим появился заказ на перевозку человека на машине (услуга такси)
            // Вызываем легковую машину и отправляем ее в путь
            company.SetCar(new ConcreteImplementor_MotorCar(4, 80)).DoWork("пункт A", "пункт Б");
            System.Console.WriteLine("-------------------------------------------------------");
            // Допустим нужно перевести песок (грузоперевозки)
            // Вызываем грузовик и отправляем его путь
            company.SetCar(new ConcreteImplementor_Truck(5000, 60)).DoWork("Порт", "поселок 'Дружба'");
            System.Console.WriteLine("-------------------------------------------------------");
            // Допустим нужно перевести группу людей (рейсовый маршрут)
            // Вызываем автобус и отправляем его путь
            company.SetCar(new ConcreteImplementor_Bus(54, 50)).DoWork("г. Москва", "г. СПб");
        }
    }
}
