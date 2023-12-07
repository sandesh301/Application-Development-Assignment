using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check check = new Check();
            check.DoingSomething();

            Checking checking = new Checking();
            checking.DoingSomething();
        }
    }

    public class Check
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("I want to do something");
        }
        public void DoingSomething()
        {

        }
    }
    public class Checking : Check
    {
        public override void DoSomething()
        {
            Console.WriteLine("Doing CHecking");

        }

        public void Acceleration(string a)
        {

        }
        public void Acceleration(int a)
        {e

        }
    }
}