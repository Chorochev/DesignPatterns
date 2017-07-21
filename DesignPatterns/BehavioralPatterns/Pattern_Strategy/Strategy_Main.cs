using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Strategy
{
    public static class Strategy_Main
    {
        public static void Go()
        {            
            Context_CallingAvto callingAvto = new Context_CallingAvto();
            char key;
            System.Console.WriteLine("Вызов такси - 't'");
            System.Console.WriteLine("Вызов автобуса - 'a'");
            System.Console.WriteLine("Вызов грузовика - 'r'");
            System.Console.WriteLine("Выход - 'e'");
            do
            {
                System.Console.Write("Введите:");
                key = System.Console.ReadKey().KeyChar;
                if (key == 't') callingAvto.SetStrategy(new ConcreteStrategy_CallingTaxi());
                if (key == 'a') callingAvto.SetStrategy(new ConcreteStrategy_CallingBus());
                if (key == 'r') callingAvto.SetStrategy(new ConcreteStrategy_CallingTruck());
                System.Console.WriteLine();
                System.Console.WriteLine("-------------------------------------");
                callingAvto.strategy.Algorithm();
            } while (key != 'e');

        }
    }
}
