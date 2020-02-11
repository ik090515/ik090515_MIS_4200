using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ik090515_MIS4200.Models
{
    public class Visits
    {

        [Key] public int visitID { get; set; }
        public string description { get; set; }
        public decimal visitCost { get; set; }
        public DateTime visitDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<VisitDetails> VisitDetails { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int ownerID { get; set; }
        public virtual Owners Owners { get; set; }
    }
}