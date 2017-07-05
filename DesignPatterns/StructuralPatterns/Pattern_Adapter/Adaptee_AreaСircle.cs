using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Adapter
{
    /// <summary>
    /// Класс который нужно адаптировать
    /// Класс который высчитывает площадь фигуры - круг
    /// </summary>
    class Adaptee_AreaСircle
    {
        public double Radius { get; set; }

        public double PI { get; set; }
      
        public Adaptee_AreaСircle(double radius)
        {
            this.Radius = radius;
            this.PI = 3.14d;
        }
        /// <summary>
        /// Получить площадь квадрата
        /// </summary>
        /// <returns></returns>
        public double GettAreaOfСircle()
        {
            return (PI * (Radius*Radius));
        }
    }
}
