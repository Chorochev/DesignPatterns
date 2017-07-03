using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_FactoryMethod
{
    public static class FactoryMethod_Main
    {
        public static void Go()
        {
            Creator_Calling crt = new ConcreteCreator_Bus("Микроавтобус");
            Product_Car car = crt.FactoryMethod();
            car.PrintPoperties();

            Creator_Calling crt2 = new ConcreteCreator_TruckTransport("Грузовик");
            Product_Car car2 = crt2.FactoryMethod();
            car2.PrintPoperties();
        }
    }
}
