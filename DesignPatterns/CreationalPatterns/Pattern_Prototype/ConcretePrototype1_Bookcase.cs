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
    public class ConcretePrototype1_Bookcase : Prototype_Bookcase
    {
        /// <summary>
        /// Тип шкафа
        /// </summary>
        public string TypeBC { get; set; }
        
        public ConcretePrototype1_Bookcase(int height, int width) : base(height, width)
        {
            TypeBC = "Small";
        }

        public override void Info()
        {
            base.Info();
            System.Console.WriteLine("Тип шкафа = {0}", TypeBC);
        }
    }
}
