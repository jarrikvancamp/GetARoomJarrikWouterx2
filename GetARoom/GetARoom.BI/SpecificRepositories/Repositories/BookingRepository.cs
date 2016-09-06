using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class BookingRepository :Repository<Booking>,IBookingRepository
    {

        public BookingRepository(GetARoomEntities db) : base(db)
        {

        }

        public IEnumerable<Booking> GetAll(int roomId)
        {
            var bookings = _db.Booking.Where(x => x.RoomId == roomId);

            return bookings;        
        }

        public IEnumerable<Booking> GetAllBookingsWithRooms()
        {
            return _db.Booking.Include(b => b.Room);
        }

        public IEnumerable<Booking> GetAllBookingsWithUsers()
        {
           return _db.Booking.Include(b => b.User);
        }

        public IEnumerable<Booking> GetBookings()
        {
            return _db.Booking.Include(b => b.User).Include(b=>b.Room);
        }

        public Booking GetBookingWithRoom(int id)
        {
            return _db.Booking.Include(b => b.Room).SingleOrDefault(c=>c.BookingId == id);
        }

        public Booking GetBookingWithUser(int id)
        {
            return _db.Booking.Include(b => b.User).SingleOrDefault(c => c.BookingId == id);
        }

        public Booking GetFullBooking(int id)
        {
            return _db.Booking.SingleOrDefault(c => c.BookingId == id);
        }
    }
}
