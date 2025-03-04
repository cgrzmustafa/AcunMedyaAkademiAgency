using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaAkademiAgency.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Hour { get; set; }

    }
}