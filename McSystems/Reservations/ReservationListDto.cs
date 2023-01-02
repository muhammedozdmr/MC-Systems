using McSystems.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.Reservations
{
    public class ReservationListDto
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerNames { get; set; }
    }
}
