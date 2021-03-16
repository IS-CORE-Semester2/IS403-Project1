using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS403_Project1.Models
{
    public class Tour
    {
        [Key]
        [Required]
        public int TourID { get; set; }
        [Required]
        public DateTime Time { get; set; } 
        [Required]
        public string NameofGroup {get; set;}
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        //he puts the quadrant methods here, but I am not sure how we would implement those
        //besides checking if the times are open?

    }
}
