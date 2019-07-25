using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWheel.Models
{
    public class Review
    {
        public Review()
        {
            UserAnswers = new HashSet<UserAnswer>();
        }
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public Place Place { get; set; }
        public float Rating { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}