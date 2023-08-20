using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RezervePlace
    {
        [Key]
        public int RezervePlaceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public decimal Price { get; set; }
        public string MapUrl { get; set; }
        public int Capacity { get; set; }
    }
}
