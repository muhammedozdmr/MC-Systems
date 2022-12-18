using McSystems.DataAccess;
using McSystems.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.Business
{
    public class ReservationService
    {
        private McSystemsContext _context = new McSystemsContext();

        public CommandResult Create(ReservationDto reservationDto)
        {
            var reservation = MapToEntity(reservationDto);
            try
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                return CommandResult.Success("Rezervasyon oluşturuldu");
            }
            catch (Exception ex)
            {   
                return CommandResult.Failure("Rezervasyon hatası",ex);
            }
        }
        private Reservation MapToEntity(ReservationDto reservationDto)
        {
            return new Reservation()
            {
                Id = reservationDto.Id,
                RoomId = reservationDto.RoomId,
                StartDate = reservationDto.StartDate,
                EndDate = reservationDto.EndDate,
                EmployeeId = reservationDto.EmployeeId,
            };
        }
    }
}
