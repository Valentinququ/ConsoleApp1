using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü");
            int auswahl;
            string wiederholung;
            Console.WriteLine("1: Aktion 1");
            Console.WriteLine("2: Aktion 2");
            Console.WriteLine("3: Aktion 3");
            do
        { 
            Console.WriteLine("Aktion auswählen");
            auswahl = Convert.ToInt32(Console.ReadLine());
         

            if (auswahl == 1)
            {
                Console.WriteLine("Blöd");

            }
            else if (auswahl == 2)
            {
                Console.WriteLine("Scheiße");

            }
            else if (auswahl == 3)
            {
                Console.WriteLine("Fuck you");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");

            }
            Console.WriteLine("Neue Aktion auswählen(j/n)");
            wiederholung = Console.ReadLine();
        }while(wiederholung == "j");



        }
    }
}
