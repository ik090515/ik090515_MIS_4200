using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ik090515_MIS4200.Models
{
    public class VisitDetails
    {

        [Key] public int visitDetailID { get; set; }
        [Display(Name = "Diagnosis")]
        [Required]
        public string diagnosis { get; set; }
        [Display(Name = "Visit Date")]
        [Required]
        public DateTime visitDate { get; set; }
        // the next two properties link the orderDetail to the Order
        [Display(Name = "Visit ID")]
        [Required]
        public int visitID { get; set; }
        [Required]
        public virtual Visits Visits { get; set; }
        // the next two properties link the orderDetail to the Product
        [Required]
        public int ownerID { get; set; }
        [Required]
        public virtual Owners Owners { get; set; }
    }
}