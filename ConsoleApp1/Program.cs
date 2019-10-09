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
             Console.WriteLine("1: Dezimal zu biär");
             Console.WriteLine("2: Aktion 2");
             Console.WriteLine("3: Aktion 3");
             do
         { 
             Console.WriteLine("Aktion auswählen");
             auswahl = Convert.ToInt32(Console.ReadLine());


             if (auswahl == 1)
             {
                    string eingabe, ausgabe="";
                    int dez, quotient=1, rest;
                    Console.WriteLine("Dezimalzahl eingeben");
                    eingabe = Console.ReadLine();
                    dez = Convert.ToInt32(eingabe);

                    while(quotient != 0)
                    {
                        quotient = dez / 2;
                        rest = dez % 2;
                        ausgabe += Convert.ToString(rest);
                        dez = quotient;

                    }

                    string ausgabe_R = "";
                    for (int i = ausgabe.Length-1; i>= 0; i--)
                    {
                        ausgabe_R += ausgabe[i];
                    }

                    Console.WriteLine(eingabe + "in binär:" + ausgabe_R);
             }
             else if (auswahl == 2)
             {
                    string eingabe;
                    double dez=0;
                 Console.WriteLine("Binärzahl eingeben:");
                    eingabe = Console.ReadLine();

                    for (int i = 0; i < eingabe.Length; i++) 
                    {
                        double faktor = Convert.ToDouble(Convert.ToString(eingabe[i]));
                        double exponent = Convert.ToDouble(eingabe.Length - 1 - i);
                        dez += faktor * Math.Pow(2, exponent);
                    }
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
