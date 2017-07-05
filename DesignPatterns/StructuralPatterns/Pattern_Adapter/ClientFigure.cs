using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Adapter
{
    /// <summary>
    /// Клиент использующий адаптер
    /// </summary>
    class ClientFigure
    {
        /// <summary>
        /// Имя фигуры
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area { get; set; }

        ITargetFigure _ITargetFigure;

        public ClientFigure(){ }
        /// <summary>
        /// Устанавливаем фигуру
        /// </summary>
        /// <param name="targetFigure"></param>
        public void SetFigure(ITargetFigure targetFigure)
        {
            _ITargetFigure = targetFigure;
        }

        /// <summary>
        /// Получение площади фигуры
        /// </summary>
        /// <param name="_ITargetFigure"></param>
        public void SetArea()
        {
            this.Area = _ITargetFigure.GetArea();
        }

        public void Info()
        {
            System.Console.WriteLine("Информация о фигуре:");
            System.Console.WriteLine("Наименование: {0}", Name);
            _ITargetFigure.Info();
            System.Console.WriteLine("Площадь = {0}", Area);        
        }

    }
}
