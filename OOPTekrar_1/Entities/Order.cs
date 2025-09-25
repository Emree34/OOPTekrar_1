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
        public int ShipperId { get; set; }


        //Relational properties 

        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }
       
    }
}
