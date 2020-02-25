using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ik090515_MIS4200.Models
{
    public class Veterinarians
    {

        [Display(Name = "Vet ID")]
        [Key] public int vetID { get; set; }
        [Display(Name = "Veterinarian First Name")]
        [Required]
        public string vetFirstName { get; set; }
        [Display(Name = "Veterinarian Last Name")]
        [Required]
        public string vetLastName { get; set; }
        [Display(Name = "Veterinarian Email")]
        [Required]
        public string vetEmail { get; set; }
        [Display(Name = "Veterinarian Phone Number")]
        [Required]
        public string vetPhone { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<VisitDetails> VisitDetails { get; set; }
    }
}