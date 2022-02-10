using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    class Rechenoperation
    {
        public delegate int Del (int x, int y);

        public void Test()
        {
            Console.Write("Zahl 1: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl 2: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Wähle eine Rechenoperation:");
            Console.WriteLine("Addition         (1)");
            Console.WriteLine("Subtraktion      (2)");
            Console.WriteLine("Multiplikation   (3)");
            Console.WriteLine("Division         (4)");

            int auswahl = Convert.ToInt32(Console.ReadLine());
            Del op;

            switch(auswahl)
            {
                case 1:
                    op = new Del(Addition);
                    break;

                case 2:
                    op = new Del(Subtraktion);
                    break;

                case 3:
                    op = new Del(Multiplikation);
                    break;

                case 4:
                    op = new Del(Division);
                    break;

                default:
                    op = new Del(Addition);
                    break;
            }

            int ergebnis = op(zahl1, zahl2);

            Console.WriteLine("Das Ergebnis " + ergebnis.ToString());
            Console.ReadKey();
        }

        public int Addition(int x, int y)
        {
            return x + y;
        }
        public int Subtraktion(int x, int y)
        {
            return x - y;
        }
        public int Multiplikation(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x / y;
        }
    }
}
