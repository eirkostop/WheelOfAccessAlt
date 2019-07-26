using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWheel.Models
{
    public class Place
    {
        public Place()
        {
            Reviews = new HashSet<Review>();
        }
        public float score { get; set; }
            
        public int Id { get; set; }
        [Display(Name = "Place Name")]
        public string Name { get; set; }
        public ICollection<Review> Reviews {get;set;}
    }
}