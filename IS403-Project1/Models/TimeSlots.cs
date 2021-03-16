using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS403_Project1.Models
{
    public class TimeSlots
    {
        //I am not as sure with this one if the field are correct with the 
        //involved datetimes, so feel free to change them. 
        //I also know he suggested that we hard code in seed data basically where
        //we write in all the available codes as the seed data. I think 
        //that falls under #4 assignment but I am not sure

        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime TimeOfDay { get; set; }
    }
}
