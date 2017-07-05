using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Adapter
{
    /// <summary>
    /// класс адаптер для "Adaptee_AreaСircle"
    /// </summary>
    class AdapterCircle : ITargetFigure
    {
        Adaptee_AreaСircle _circle { get; set; }

        public AdapterCircle(double radius)
        {
            this._circle = new Pattern_Adapter.Adaptee_AreaСircle(radius);
        }
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return this._circle.GettAreaOfСircle();
        }

        public void Info()
        {
            System.Console.WriteLine("Радиус = {0}", _circle.Radius);            
        }
    }
}
