using System;

namespace ConsoleAppDelegate
{
    public class Delegate
    {
        public delegate void Del(string message);

        public Delegate()
        {
            Del handler = DelegateMethod;
            handler("Hello World");
        }      

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
