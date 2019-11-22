using System;

namespace DesignPatterns_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patters - Singleton!");

            Singleton s1 = Singleton.Instance;

            s1.LogMessage("First singleton message");

            Singleton s2 = Singleton.Instance;
            s1.LogMessage("Second singleton message");

            if (s1.Equals(s2))
            {
                Console.WriteLine("Singleton works perfectly!");
            }
        }
    }

    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(()=>new Singleton());

        private Singleton ()
        {
            instanceCounter += 1;
            Console.WriteLine($"Instance created {instanceCounter}");
        }

        public static Singleton Instance
        {
            get { return _instance.Value; }
        }

        private static int instanceCounter = 0;

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
