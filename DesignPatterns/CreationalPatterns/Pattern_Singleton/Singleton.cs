/*  Классическая реализация данного шаблона проектирования */
namespace DesignPatterns.CreationalPatterns.Pattern_Singleton
{   
    class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton getgetInstance()
        {
            if (_instance == null) _instance = new Singleton();
            return _instance;
        }
    }
}
