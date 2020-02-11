using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ik090515_MIS4200.Models
{
    public class Veterinarians
    {

        [Key] public int vetID { get; set; }
        public string vetFirstName { get; set; }
        public string vetLastName { get; set; }
        public string vetEmail { get; set; }
        public string vetPhone { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<VisitDetails> VisitDetails { get; set; }
    }
}