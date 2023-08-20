using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Gallery
    {
        [Key]
        public int GalleryID { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
