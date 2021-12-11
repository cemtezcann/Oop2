using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{    
    class GercekMusteri:Musteri
    {
       
        public string TcNo { get; set; }  // Bir degiskenin üzerinde işlem yapmıyorsan string olarak tanımlama,diğer programlarla uyumlu olsun diye...
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
