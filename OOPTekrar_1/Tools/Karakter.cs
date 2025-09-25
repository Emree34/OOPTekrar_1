using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Tools
{
    public class Karakter
    {
        // Seviye'nin ve Can'nı sadece baslangicta yani sadece nesne yaratılırken seviyenin sadece 1'den  baslamasını saglayın can'ın 100'den asagı olmamasını saglayın sonra bunlara istenildiği gibi değer atanabilir

        public Karakter(int can) 
        {
            Seviye = 1;
            if (can < 100) 
            {
                can = 100;
            }
            else 
            {
                can = can;
            }
        }


        public string Isim { get; set; }
        public int Seviye { get; private set; }
        public int Can { get; set; }

        public void SeviyeAta(int seviye) 
        {
            seviye = Seviye;
        }
    }
}
