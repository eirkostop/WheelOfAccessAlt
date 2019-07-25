using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWheel.Models
{
    public class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }

    }
}