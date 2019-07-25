using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyWheel.Models
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}