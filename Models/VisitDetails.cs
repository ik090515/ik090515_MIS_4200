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
        public string diagnosis { get; set; }
        public DateTime visitDate { get; set; }
        // the next two properties link the orderDetail to the Order
        public int visitID { get; set; }
        public virtual Visits Visits { get; set; }
        // the next two properties link the orderDetail to the Product
        public int ownerID { get; set; }
        public virtual Owners Owners { get; set; }
    }
}