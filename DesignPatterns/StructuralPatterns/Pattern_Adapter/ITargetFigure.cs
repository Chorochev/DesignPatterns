using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Adapter
{
    /// <summary>
    /// класс который представляет методы которые нужны клиенту
    /// </summary>
    interface ITargetFigure
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        /// <returns></returns>
        double GetArea();
        /// <summary>
        /// Информация о фигуре
        /// </summary>
        void Info();
    }
}
