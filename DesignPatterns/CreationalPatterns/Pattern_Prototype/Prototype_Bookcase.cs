using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Prototype
{
    /// <summary>
    /// Шкаф. Интерфейс для клонирования самого себя.
    /// </summary>
    public abstract class Prototype_Bookcase
    {
        /// <summary>
        /// Ширина шкафа
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Высота шкафа
        /// </summary>
        public int Height { get; set; }
        
        public Prototype_Bookcase(int height, int width)
        {
            Width = width;
            Height = height;
        }

        public virtual void Info()
        {
            System.Console.WriteLine("Характеристики шкафа:");
            System.Console.WriteLine("Высота = {0}", Height);
            System.Console.WriteLine("Ширина = {0}", Width);
        }

        /// <summary>
        /// Клонирование самого себя
        /// </summary>
        /// <returns></returns>
        public virtual Prototype_Bookcase Clone()
        {
            // Shallow copy
            return (Prototype_Bookcase)this.MemberwiseClone();
        }
    }
}
