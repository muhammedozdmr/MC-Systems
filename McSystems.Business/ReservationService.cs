using McSystems.Customers;
using McSystems.DataAccess;
using McSystems.DataAccess.Entities;
using McSystems.Reservations;
using McSystems.Reservations;
using McSystems.Rooms;
using McSystems.Rooms;
using Microsoft.EntityFrameworkCore;

namespace McSystems.Business
{
    public class ReservationService
    {
        private Reservation _reservation = new Reservation();
        private McSystemsContext _context = new McSystemsContext();

        public CommandResult Create(ReservationDto reservationDto)
        {
            var reservation = MapToEntity(reservationDto);
            try
            {
                _context.Reservations.Add(reservation);
                //TODO: Berkcandaki gibi state yap Entry tarafında
                //reservation entity nesnesini context'e Add metodu ile tanıttığımızda o reservation
                //nesnesi veritabanına SaveChanges metodu çağrıldığında Insert edilecek
                
                //Ancak bu işlemin şöyle bir yan etkisi söz konusu !! reservation nesnesi ile birlikte onun
                //üzerindeki referans Customer nesneleri de Added durumu ile context'e tanıtılmış olur.

                //Rezervasyon kaydı üzerinde her bir Customer nesnesinin Context'e tanıtılmış olmasında bir sakınca yok,
                //hata rezervasyona zaten müşteri ekleyebilmek içi bunun yapılmış olması gerekir
                //Ancak burada sorun olan durum; o Customer nesnelerinin Added (yeni kayıt) bilgisi ile tanıtılmış olmasıdır.

                //Bu sebeple, REservation nesnesini context'e tanıttıktan sonra kendisi ile birlikte
                //otomatik olarak Context'e tanıtılmış Customer nesnelerini tektek dolaşıp, durum bilgilerini
                //Unchanged(değişiklik görmemiş, var olan kayıt) olarak değiştirmem gerekir
                foreach(var customer in reservation.Customers)
                {
                    _context.Entry(customer).State = EntityState.Unchanged;
                }
                _context.SaveChanges();
                return CommandResult.Success("Rezervasyon oluşturuldu");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Rezervasyon hatası", ex);
            }
        }
        public List<ReservationDto> GetAll()
        {
            try
            {
                return _context.Reservations.Select(MapToDto).ToList();
            }
            catch (Exception)
            {
                return new List<ReservationDto>();
            }
        }
        public CommandResult Cancel(ReservationDto reservationDto)
        {
            var reservation = new Reservation()
            {
                Id = reservationDto.Id,
            };
            try
            {
                _context.Reservations.Remove(reservation);
                return CommandResult.Success("İptal başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("İptal işlemi hatalı", ex);
            }
        }
        public List<RoomDto> GetAvailableRoomsByDateRange(DateTime strartDate, DateTime endDate)
        {
            try
            {
                var notAvailableRooms = _context.Reservations
                    .Where(res => res.StartDate >= strartDate && res.StartDate <= endDate ||
                    res.EndDate >= strartDate && res.EndDate <= endDate ||
                    strartDate >= res.StartDate && strartDate <= res.EndDate ||
                    endDate >= res.StartDate && endDate <= res.EndDate)
                    .Select(reservation => reservation.RoomId).ToList();
                var result = _context.Rooms.Where(room => !notAvailableRooms.Contains(room.Id)).Select(MapToDtoRoom).ToList();
                if (result!=null)
                {
                    return result;
                }
                return new List<RoomDto>();
            }
            catch (Exception)
            {
              return new List<RoomDto>();
            }
        }
        private Reservation MapToEntity(ReservationDto reservationDto)
        {
            var reservation = new Reservation()
            {
                Id = reservationDto.Id,
                RoomId = reservationDto.RoomId,
                StartDate = reservationDto.StartDate,
                EndDate = reservationDto.EndDate,
                EmployeeId = reservationDto.EmployeeId,
            };
            foreach(var item in reservationDto.Customers)
            {
                //TODO: maplemeyi unutma sadece id yazıyor isim falanda gelmesi gerek
                //direkt customer serviceten maptoentity çağırabilirsin
                var customer = new Customer();
                customer.Id = item.Id;
                reservation.Customers.Add(customer);
            }
            return reservation;
        }
        private ReservationDto MapToDto(Reservation reservation)
        {
            return new ReservationDto()
            {
                Id = reservation.Id,
                RoomId = reservation.RoomId,
                StartDate = reservation.StartDate,
                EndDate = reservation.EndDate,
                EmployeeId = reservation.EmployeeId
            };
        }
        private RoomDto MapToDtoRoom(Room room)
        {
            return new RoomDto()
            {
                Id = room.Id,
                Floor = room.Floor,
                Capacity = room.Capacity,
                Description = room.Description,
                InMaintenance = room.InMaintenance,
                Number = room.Number,
                RoomType = room.RoomType,
            };
        }
        //public List<ReservationListDto> GetCustomersListObjects(ReservationDto reservationDto)
        //{
        //    var customerFullName = _context.Customers.Where(cus=>cus.)
        //    var result = _context.Reservations.Select(res => new ReservationListDto()
        //    {
        //        Id = res.Id,
        //        RoomName = res.Room.Name,
        //        EmployeeName = res.Employee.FirstName,
        //        CustomerNames = res.Customers.Select(res=> new Customer()
        //        {
                    
        //        },
        //        StartDate = res.StartDate,
        //        EndDate = res.EndDate
        //    });
        //}
    }
}
