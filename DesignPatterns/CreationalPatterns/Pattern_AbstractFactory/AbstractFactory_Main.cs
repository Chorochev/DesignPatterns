using System;

namespace DesignPatterns.CreationalPatterns.Pattern_AbstractFactory
{
    public static class AbstractFactory_Main
    {
        public static void Go()
        {
            Console.WriteLine("------- ConcreteFactory1 -------");
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.InfoProductA();
            client1.InfoProductB();
            Console.WriteLine("------- ConcreteFactory2 -------");
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.InfoProductA();
            client2.InfoProductB();

        }
    }
}
