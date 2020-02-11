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
        public string petName { get; set; }
        public string ownerFirstName { get; set; }
        public string ownerLastName { get; set; }
        public string ownerEmail { get; set; }
        public string ownerPhone { get; set; }
        public DateTime customerSince { get; set; }

        public ICollection<Visits> Visits { get; set; }

    }


}

