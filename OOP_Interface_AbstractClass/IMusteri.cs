using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface_AbstractClass
{
    public interface IMusteri
    {
        // Interface içerisinde ctor yani yapıcı metot kullanılmaz.


        //field
         int id { get; set; }
         string isim{ get; set; }
         string soyisim{ get; set; }

        // metot
        int yeniKayit(string isim , string soyisim);
        int kayitDuzenle(int id, string isim , string soyisim);
        int KayitSil(int id);

    }
}
