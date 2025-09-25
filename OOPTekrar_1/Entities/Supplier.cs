using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class Supplier
    {
        public string  SupplierName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Order> Orders { get; set; }
    }
}
