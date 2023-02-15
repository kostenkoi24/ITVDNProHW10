using System;

namespace Homework10_2
{

    public class Base
    {
        public void DoWork() // Шаблонний метод
        {
            PreDoWork();
            CoreDoWork();
        }

        protected virtual void PreDoWork() { Console.WriteLine("0"); }
        protected virtual void CoreDoWork() { Console.WriteLine("1"); } //будет замещён методом из Derived класса
    }

    public class Derived : Base
    {
        protected override void CoreDoWork() { Console.WriteLine("2"); }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Base instance = new Derived(); 
            instance.DoWork();  // Console.WriteLine("2")

            // Delay
            Console.ReadKey();
        }
    }
}
