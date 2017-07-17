using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Proxy
{
    /// <summary>
    /// Proxy - заместитель
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>хранит ссылку, которая позволяет заместителю обратиться к реальному
    /// субъекту. Объект класса <see cref="Math_Proxy"/> может обращаться к объекту класса
    /// <see cref="IMath_Subject"/>, если интерфейсы классов <see cref="Math_RealSubject"/> и <see cref="IMath_Subject"/> одинаковы;</lu>
    /// <lu>предоставляет интерфейс, идентичный интерфейсу <see cref="IMath_Subject"/>, так что заместитель
    /// всегда может быть предоставлен вместо реального субъекта;</lu>
    /// <lu>контролирует доступ к реальному субъекту и может отвечать за его создание 
    /// и удаление;</lu>
    /// <lu>прочие обязанности зависят от вида заместителя:
    /// <li>
    /// <lu><b>удаленный заместитель</b> отвечает за кодирование запроса и его аргументов
    /// и отправление закодированного запроса реальному субъекту в
    /// другом адресном пространстве;</lu>
    /// <lu><b>виртуальный заместитель</b> может кэшировать дополнительную информацию
    /// о реальном субъекте, чтобы отложить его создание.</lu>
    /// <lu><b>защищающий заместитель</b> проверяет, имеет ли вызывающий объект 
    /// необходимые для выполнения запроса права;</lu>
    /// </li>
    /// </lu>
    /// </li>
    /// </remarks>
    class Math_Proxy : IMath_Subject
    {
        Math_RealSubject math;

        public Math_Proxy()
        {
            math = null;
        }

        /// <summary>
        /// Быстрая операция - не требует реального субъекта
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Медленная операция - требует создания реального субъекта
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Mul(double x, double y)
        {
            if (math == null)
                math = new Math_RealSubject();
            return math.Mul(x, y);
        }

        public double Div(double x, double y)
        {
            if (math == null)
                math = new Math_RealSubject();
            return math.Div(x, y);
        }
    }

}
