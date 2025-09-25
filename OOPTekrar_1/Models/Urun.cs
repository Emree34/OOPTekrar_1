using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPTekrar_1.Models
{
    public class Urun
    {
        public Urun(string Isim, decimal Fiyat) 
        {
            Isim = Isim;

            Fiyat = Fiyat;

        }


        public string Isim { get; set; }

        decimal _Fiyat;
        public decimal Fiyat
        {
            get
            {
                return _Fiyat;
            }
            set
            {
                if (value < 10)
                {
                    MessageBox.Show("Deger 10'dan kucuk olamaz");
                }
                _Fiyat = value;
            }
        }
            
           
          
        public Kategori Kategori { get; set; }


    }
}
