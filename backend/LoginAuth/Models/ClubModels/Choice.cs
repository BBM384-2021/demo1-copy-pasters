using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ClubModels
{
    public class Choice
    {
        [Key]
        public int ID { get; set; }
        
        public string Text { get; set; }
    }
}