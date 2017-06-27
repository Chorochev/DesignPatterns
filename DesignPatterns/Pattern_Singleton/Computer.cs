
namespace DesignPatterns.Pattern_Singleton
{
    class Computer
    { 
        public SingletonOS OS { get; set; }

        public void Launch(string osName)
        {
            OS = SingletonOS.getInstance(osName);
        }
    }
}
