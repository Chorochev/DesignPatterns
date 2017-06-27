using System;

namespace DesignPatterns.CreationalPatterns.Pattern_Singleton
{
    public static class Singleton_Main
    {
        /// <summary>
        /// Пример использования шаблона "Одиночка"
        /// </summary>
        public static void Go()
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
