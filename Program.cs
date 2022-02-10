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
            Console.WriteLine("A: Delegate S:Callbacks D:Rechenoption");
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

                case ConsoleKey.D:
                    Rechenoperation rechenoperation = new Rechenoperation();
                    rechenoperation.Test();
                    break;

                default:
                    break;
            }

            Console.ReadKey();
        }      
    }
}
