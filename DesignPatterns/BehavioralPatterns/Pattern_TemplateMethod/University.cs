using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_TemplateMethod
{
    /// <summary>
    /// ConcreteClass: подкласс, который может переопределять различные методы родительского класса.
    /// Конкретная реализация обучения в университете.
    /// </summary>
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
        }

        public override void PassExams()
        {
            Console.WriteLine("Сдаем экзамен по специальности");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем диплом о высшем образовании");
        }
    }
}
