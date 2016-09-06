using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IBookingRepository  : IRepository<Booking>
    {
        IEnumerable<Booking> GetAllBookingsWithRooms();
        IEnumerable<Booking> GetAllBookingsWithUsers();
        IEnumerable<Booking> GetBookings();

        Booking GetBookingWithRoom(int id);
        Booking GetBookingWithUser(int id);
        Booking GetFullBooking(int id);
        IEnumerable<Booking> GetAll(int roomId);
    }
}
