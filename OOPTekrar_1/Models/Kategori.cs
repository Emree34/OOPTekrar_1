using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Models
{
    public class Kategori
    {
        public Kategori(string Isim, string Aciklama) 
        {
            Isim = Isim;
            Aciklama = Aciklama;
                
        }

        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}
