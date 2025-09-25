using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class AppUserProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Relational properties 

        public virtual AppUser AppUser { get; set; }
    }
}
