using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ClubModels
{
    public class SubClub
    {
        [Key]
        public int SubClubID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}