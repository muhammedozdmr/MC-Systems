using McSystems.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.Reservations
{
    public class ReservationDto
    {
        public ReservationDto()
        {
            Customers = new List<CustomerDto>();
        }
        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? EmployeeId { get; set; }
        public List<CustomerDto> Customers { get; }
    }
}
