using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Decorator
{
    class DecoratorCake : ComponentCake
    {
        protected ComponentCake _componentCake;

        public DecoratorCake(string name, ComponentCake componentCake) : base(name)
        {
            _componentCake = componentCake;
        }
        /// <summary>
        /// Получение стоимости торта
        /// </summary>
        /// <returns></returns>
        public override double GetCost()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Получение свойств торта
        /// </summary>
        /// <returns></returns>
        public override List<string> GetProperties()
        {
            throw new NotImplementedException();
        }
    }
}
