using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.Customers
{
    public class CustomerRegistrationInfo
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
