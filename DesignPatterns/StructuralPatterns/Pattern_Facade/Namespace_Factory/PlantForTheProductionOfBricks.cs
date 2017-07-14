using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Facade.Namespace_Factory
{
    /// <summary>
    /// Это компонент сложной подсистемы, с которой должен взаимодействовать клиент.    
    /// В данном случае этот класс описывает "Завод который будет производить кирпичи".
    /// </summary>
    internal class PlantForTheProductionOfBricks
    {
        /// <summary>
        /// Количество кирпичей
        /// </summary>
        public int CountBricks { get; private set; } 
        /// <summary>
        /// Тип кирпича
        /// </summary>
        public string TypeBricks { get; private set; }
        /// <summary>
        /// Завод который производит кирпичи
        /// </summary>
        public PlantForTheProductionOfBricks()
        {

        }
        /// <summary>
        /// Создание кирпичей
        /// </summary>
        /// <param name="countBricks">количество</param>
        /// <param name="TypeBricks">тип</param>
        public void Create(int countBricks, string TypeBricks)
        {
            PrintInfo("Производство кирпичей типа '{0}' в количестве {1}.", TypeBricks, countBricks);
        }

        /// <summary>
        /// Печать сообщений.
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <param name="args">аргументы</param>
        private void PrintInfo(string message, params object[] args)
        {
            System.Console.WriteLine("Завод по производсту кирпичей.");
            System.Console.Write("Событие: ");
            System.Console.WriteLine(message, args);
        }
    }
}
