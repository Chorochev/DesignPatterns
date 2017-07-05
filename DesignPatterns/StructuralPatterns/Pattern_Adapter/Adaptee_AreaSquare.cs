using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Adapter
{
    /// <summary>
    /// Класс который нужно адаптировать
    /// Класс который высчитывает площадь фигуры - квадрат
    /// </summary>
    class Adaptee_AreaSquare
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Adaptee_AreaSquare(double wight, double height)
        {
            this.Width = wight;
            this.Height = height;
        }
        /// <summary>
        /// Получить площадь квадрата
        /// </summary>
        /// <returns></returns>
        public double GettAreaOfSquare()
        {
            return (Width * Height);
        }
    }
}
