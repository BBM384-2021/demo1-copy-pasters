using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ClubModels
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public ICollection<Choice> Choices { get; set; }
    }
}