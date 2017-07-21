using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_TemplateMethod
{
    /// <summary>
    /// AbstractClass: определяет шаблонный метод TemplateMethod(), который реализует 
    /// алгоритм. Алгоритм может состоять из последовательности вызовов других методов, 
    /// часть из которых может быть абстрактными и должны быть переопределены в 
    /// классах-наследниках. При этом сам метод TemplateMethod(), представляющий структуру 
    /// алгоритма, переопределяться не должен.
    /// Базовый алгоритм для обучения в различных учебных заведениях.
    /// </summary>
    abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams()
        {
            Console.WriteLine("Сдаем выпускные экзамены");
        }
        public abstract void GetDocument();
    }
}
