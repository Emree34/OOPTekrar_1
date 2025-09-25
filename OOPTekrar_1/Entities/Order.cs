using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class Order
    {
        public string Adres { get; set; }
        public int AppUserId { get; set; }


        public AppUser AppUser { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
