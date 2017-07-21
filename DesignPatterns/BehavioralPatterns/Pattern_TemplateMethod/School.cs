using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_TemplateMethod
{
    /// <summary>
    /// ConcreteClass: подкласс, который может переопределять различные методы родительского класса.
    /// Конкретная реализация обучения в школе.
    /// </summary>
    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем уроки, делаем домашние задания");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании");
        }
    }
}
