
namespace DesignPatterns.Pattern_Singleton
{
    class SingletonOS
    {
        private static SingletonOS _OS;

        public string Name { get; private set; }

        protected SingletonOS(string name)
        {
            Name = name;
        }

        public static SingletonOS getInstance(string name)
        {
            if (_OS == null) _OS = new SingletonOS(name);
            return _OS;
        }
    }
}
