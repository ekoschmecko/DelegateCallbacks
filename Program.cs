using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: Delegate S:Callbacks");
            ConsoleKey i = Console.ReadKey().Key;

            Console.Clear();

            switch(i)
            {
                case ConsoleKey.A:
                    Delegate del = new Delegate();
                    break;

                case ConsoleKey.S:
                    CallBacks call = new CallBacks();
                    break;

                default:
                    break;
            }

            Console.ReadKey();
        }

        public delegate void Del(string message);

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void Rueckruffunktion(string text)
        {
            Console.WriteLine("Der Rückruf lautet:" + text);
        }
    }
}