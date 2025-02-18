using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface_AbstractClass
{
    public abstract class temelSinif
    {
        public DateTime kayitTarihi { get; set; }
        public DateTime guncellemeTarihi { get; set; }

        public temelSinif() {
            kayitTarihi = DateTime.Now;
            guncellemeTarihi = DateTime.Now;
        }

        public void test()
        {
            Console.WriteLine("temel sinif => test");
        }
        public abstract void testAbstract();
    }
}
