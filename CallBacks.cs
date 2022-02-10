using System;

namespace ConsoleAppDelegate
{
    public class CallBacks
    {
        public CallBacks()
        {
            Nebenklasse objekt = new Nebenklasse();
            objekt.Aufrufmethode(Rueckruffunktion);
        }

        public static void Rueckruffunktion(string text)
        {
            Console.WriteLine("Der Rückruf lautet:" + text);
        }
    }

    public class Nebenklasse
    {
        public void Aufrufmethode(Action<string> rueckruf)
        {
            rueckruf("Ich komme sofort zurück.");
        }
    }
}

