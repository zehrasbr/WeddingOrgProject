using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Place
    {
        public int PlaceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
