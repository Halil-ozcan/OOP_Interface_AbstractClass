using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //temelSinif t1 = new temelSinif(); abstract class new ile çağrılamaz

            musteri musteri = new musteri();
            musteri.test();
            musteri.testAbstract();
        }
    }
}
