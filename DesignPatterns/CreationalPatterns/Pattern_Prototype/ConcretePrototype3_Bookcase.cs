using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Prototype
{
    /// <summary>
    /// Конкретная реализации прототипа
    /// </summary>
    public class ConcretePrototype3_Bookcase : Prototype_Bookcase
    {
        /// <summary>
        /// Тип шкафа
        /// </summary>
        public string TypeBC { get; set; }

        public ConcretePrototype3_Bookcase(int height, int width) : base(height, width)
        {
            TypeBC = "Big";
        }
    }
}
