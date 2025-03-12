using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11B
{
    internal class Ucgen
    {
        int a;
        int b;
        int c;


        public int A
        {
           get { return a; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı Bilgi");
                else
                    a = value;

            }
        }

        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatalı bilgi");
                else
                    b = value;
            }
        }

        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatalı bilgi");
                else
                    c = value;
            }
        }

        public int Cevre
        {
            get
            {
                return a+ b + c;
            }
        }



    }
}
