using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ClubModels
{
    public class Club
    {
        [Key]
        public int ClubID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<SubClub> SubClubs { get; set; }
    }
}