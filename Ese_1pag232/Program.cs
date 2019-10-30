using ClassLibrary1pag232;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_1pag232
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserici il valore della x");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("inserici il valore della y");
            int y = int.Parse(Console.ReadLine());
            int ris = Mistero.Mistero1(x, y);
            int ris2 = Mistero.Mistero2(x, y);
            int ris3 = Mistero.Mistero3(x, y);
            int ris6 = Mistero.Mistero6(x, y);
            int ris7 = Mistero.Mistero7(x, y);
            Console.WriteLine("inserici il valore della n");
            long n = long.Parse(Console.ReadLine());
            long ris4 = Mistero.Mistero4(n);
            Console.WriteLine("inserici il valore della a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserici il valore della b");
            int b = int.Parse(Console.ReadLine());
            int ris8 = Mistero.Mistero8(a, b);
            Console.WriteLine("inserici il valore della n");
            int n1 = int.Parse(Console.ReadLine());
            int ris5 = Mistero.Mistero5(n1);
            Console.WriteLine($" il mistero è {ris}, il mistero2 è {ris2}, il mistero3 è {ris3}, il mistero4 è {ris4}, il mistero5 è {ris5}, il mistero6 è {ris6}, il mistero7 è {ris7}, il mistero8  è {ris8}");
            Console.ReadLine();
           
        } 
    }
}
