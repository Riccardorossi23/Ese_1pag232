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
        public static int mistero2(int x,int y)
        {

            if (y == 0)
                return 0;
            return (Mistero1(x, mistero2(x, y - 1)));
            
        }
        public static int mistero3(int x,int y)
        {
            if (y == 0)
                return 1;
            return mistero2(x,mistero3(x,y-1)));
        }
        public static int Mistero4(long n)
        {
           
            if 

        }
            
    }
}

   

