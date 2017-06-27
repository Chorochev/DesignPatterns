using System;

namespace DesignPatterns.Pattern_Singleton
{
    public static class Singleton_Main
    {
        public static void My_Main()
        {
            Computer comp = new Computer();
            comp.Launch("Windows 10");
            Console.WriteLine(comp.OS.Name);
            // Пытаемся изменить класс SingletonOS
            comp.Launch("Windows XP");
            Console.WriteLine(comp.OS.Name);
            // Пытаемся изменить класс SingletonOS
            comp.OS = SingletonOS.getInstance("Linux");
            Console.WriteLine(comp.OS.Name);
        }
    }
}
