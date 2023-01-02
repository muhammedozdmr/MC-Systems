using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.DataAccess.Entities
{
    public class Reservation
    {
        public Reservation()
        {
            Customers = new List<Customer>();
        }
        public int Id { get; set; } 
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? EmployeeId { get; set; }

        //Çoka çok bağlantı için Customer a da aynı şekilde ICollection yapmak gerekiyor
        public ICollection<Customer> Customers { get;}
        public Room Room { get; set; }
        public Employee Employee { get; set; }
    }
}
