using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface_AbstractClass
{
    internal class musteris : IMusteri
    {

        int _id;
        string _name;
        string _soyisim;
        public int id 
        { 
            get { return _id; } 
            set { _id = value;  } 
        }
        public string isim 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public string soyisim 
        { 
            get { return _soyisim; } 
            set { _soyisim = value; }
        }

        public int kayitDuzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("Kayit Düzenlendi");
            return 1;
        }

        public int KayitSil(int id)
        {
            Console.WriteLine("Kayit Silindi");
            return 1;
        }

        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("Yeni Kayit Yapıldı");
            return 1;
        }
    }
}
