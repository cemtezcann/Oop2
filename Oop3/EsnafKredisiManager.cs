using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class EsnafKredisiManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }

        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        
    }
}
