using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Uygulamaları_Stajı
{
    class IMALAT

    {
        public string MakinaUzmanı (int A)
        {
            string[] Amir = { "Onur Kutlu", "Mustafa Kurt", "Sezgin Bayram" };
            string Sorumlu = Amir[A];
            return Sorumlu;
            
        }
        public string Makinalar(int lider)
        {
            string[] Operatorler = { "Enjeksiyon Makinası", "Ekstrüzyon Makinası", "Presleme Makinası" };
            string Makina = Operatorler[lider];
            return Makina;
            
            
      

        }

        
    }
}
