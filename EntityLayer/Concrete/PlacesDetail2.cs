using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PlacesDetail2 
    {
        [Key]
        public int PlacesDetailID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateTime { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
    }
}
