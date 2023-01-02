using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.Customers
{
    public class CustomerSummary
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public string CountryName { get; set; }
    }
}
