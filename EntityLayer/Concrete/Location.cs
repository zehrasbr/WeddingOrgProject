using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public string Address { get; set; }
    }
}
