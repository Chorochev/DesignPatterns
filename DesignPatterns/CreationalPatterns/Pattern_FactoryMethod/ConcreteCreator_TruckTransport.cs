using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_FactoryMethod
{
    /// <summary>
    /// Создатель конкретного класса "Машины" - Грузовик
    /// </summary>
    class ConcreteCreator_TruckTransport : Creator_Calling
    {
        public ConcreteCreator_TruckTransport(string type) : base(type)
        {
        }

        public override Product_Car FactoryMethod()
        {
            return new ConcreteCar_TruckTransport("testName", TypeCar);
        }
    }
}
