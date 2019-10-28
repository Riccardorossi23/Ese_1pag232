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
            int ris2 = Mistero.mistero2(x, y);
            int ris3 = Mistero.mistero2(x, y);
            Console.Write("")
            Console.WriteLine($" il mistero è {ris}, il mistero2 è {ris2}");
            Console.ReadLine();
           
        } 
    }
}
