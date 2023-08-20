using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rezervation
    {
        public int RezervationID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
    }
}
