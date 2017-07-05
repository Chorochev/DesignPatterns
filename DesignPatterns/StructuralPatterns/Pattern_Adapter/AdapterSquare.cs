using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Adapter
{
    /// <summary>
    ///  класс адаптер для "Adaptee_AreaSquare"
    /// </summary>
    class AdapterSquare : ITargetFigure
    {
        Adaptee_AreaSquare _square { get; set; }

        public AdapterSquare(double wight, double height)
        {
            this._square = new Adaptee_AreaSquare(wight, height);
        }
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return this._square.GettAreaOfSquare();
        }

        public void Info()
        {
            System.Console.WriteLine("Ширина = {0}", _square.Width);
            System.Console.WriteLine("Высота = {0}", _square.Height);
        }
    }
}
