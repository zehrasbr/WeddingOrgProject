using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int PlaceID { get; set; }
        public Place Place { get; set; }
    }
}
