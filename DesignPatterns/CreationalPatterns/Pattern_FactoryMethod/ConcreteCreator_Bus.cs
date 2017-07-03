using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_FactoryMethod
{
    /// <summary>
    /// Создатель конкретного класса "Машины" - Автобуса.
    /// </summary>
    class ConcreteCreator_Bus : Creator_Calling
    {
        private string GetNumberBus()
        {
            var num = Guid.NewGuid();
            return num.ToString();
        }

        public ConcreteCreator_Bus(string type) : base(type)
        {
        }

        public override Product_Car FactoryMethod()
        {
            return new ConcreteCar_Bus(GetNumberBus(), this.TypeCar);
        }
    }
}
