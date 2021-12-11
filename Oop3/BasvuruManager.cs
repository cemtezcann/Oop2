using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class BasvuruManager
    {    //Method injection 
        public void BasvuruYap(IKrediManager krediManager ,List<ILoggerService> loggerServices)
        {     //Soyut halleri var somut hallerine enjekte ediyoruz burada.
            //Başvuran bilgilerini değerlendirme
            //
           
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices )
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
