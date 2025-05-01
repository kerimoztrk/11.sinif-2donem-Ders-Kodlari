using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11A
{
    internal class Kahramann
    {
        public string Ad;
        public int Can;

        public Kahramann(string ad)
        {
            Ad = ad;
            Can = 100;
        }

        public virtual void Saldir()
        {
            Console.WriteLine($"{Ad} yumruk attı!");

        }
    }
}
