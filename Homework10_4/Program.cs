using System;

namespace Homework10_4
{

    public abstract class Animal
    {
        public void Speak()
        {
            GetSound();
        }
        protected abstract void GetSound();
     
    }

    class Dog : Animal
    {
        protected override void GetSound()
        {
            Console.WriteLine("Gav-Gav") ;
        }
    }
    class Cow : Animal
    {
        protected override void GetSound()
        {
            Console.WriteLine("Mu-Muuu");
        }
    }

    class Program
    {
        /*Реалізуйте шаблон NVI у власній ієрархії успадкування.*/
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Speak();

            Cow cow = new Cow();
            cow.Speak();
            Console.ReadKey();
        }
    }
}
