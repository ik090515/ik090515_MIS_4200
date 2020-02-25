using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ik090515_MIS4200.Models
{
    public class Owners
    {

        [Key] public int ownerID { get; set; }
        [Display(Name = "Pet Name")]
        [Required]
        public string petName { get; set; }
        [Display(Name = "Owner First Name")]
        [Required]
        public string ownerFirstName { get; set; }
        [Display(Name = "Owner Last Name")]
        [Required]
        public string ownerLastName { get; set; }
        [Display(Name = "Owner Email")]
        [Required]
        public string ownerEmail { get; set; }
        [Display(Name = "Owner Phone")]
        [Required]
        public string ownerPhone { get; set; }
        [Required]
        public DateTime customerSince { get; set; }

        public ICollection<Visits> Visits { get; set; }

    }


}

