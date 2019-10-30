using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1pag232
{
    public class Mistero
    {
        public static int Mistero1(int x, int y)
        {
            int prec;
            if (y == 0)
                return x;
            prec = Mistero1(x, y - 1) + 1;
            return prec;
        }
        public static int Mistero2(int x, int y)
        {

            if (y == 0)
                return 0;
            return (Mistero1(x, Mistero2(x, y - 1)));

        }
        public static int Mistero3(int x, int y)
        {
            if (y == 0)
                return 1;
            return Mistero2(x, Mistero3(x, y - 1));
        }
        public static int Mistero4(long n)
        {

            Console.WriteLine(n % 10);
            if (n / 10 != 0)
            {
                return Mistero4(n / 10);
            }
            throw new Exception("non andrà");


        }
        public static int Mistero5(int n1)
        {
            if (n1 == 0)
            {
                return 0;
            }
            else if (n1 == 1)
            {
                return 1;
            }
            return (Mistero5(n1 - 1) + Mistero5(n1 - 2));
        }
        public static int Mistero6(int x, int y)
        {
            if (x < 0)
            {
                return Mistero6(x + y, y);
            }
            else if (x < y)
            {
                return x;
            }
            else
            {
                return Mistero6(x - y, y);
            }


        }
        public static int Mistero7(int x, int y)
        {
            int z = 1;
            if (y < 0)
            {
                Console.WriteLine("Il valore è sbagliato");
            }
            else if (y > 0)
            {
                z = x * Mistero7(x, y - 1);
            }
            return z;


        }
        public static int Mistero8(int a, int b)
        {
            int z;
            z = a % b;
            if (z == 0)
            {
                return b;
            }
            else if (a == b && b == z)
            {
                return Mistero8(a , b);
            }
               
        }
    }
}

              



   

