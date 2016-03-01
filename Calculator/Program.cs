using CalcClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Calculator");

            Operatori suma = new Operatori();
            Console.WriteLine("Prvi broj je:");
            int prviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Drugi broj je:");
            int drugiBroj = int.Parse(Console.ReadLine());
            int nesto = suma.Add(prviBroj, drugiBroj);

            Console.WriteLine("Rezultat zbroja {0} i {1} je: {2}", prviBroj, drugiBroj, nesto);
            Console.WriteLine("Danas je {0}", DateTime.Today.DayOfWeek);
        }
    }
}
