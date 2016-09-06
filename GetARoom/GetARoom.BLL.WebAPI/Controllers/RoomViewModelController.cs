using GetARoom.BLL.WebAPI.Models.ViewModels;
using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetARoom.BLL.WebAPI.Controllers
{
    public class RoomViewModelController : ApiController
    {
        UnitOfWork unit = new UnitOfWork(new GetARoomEntities());
        public IEnumerable<RoomListViewModel> GetAll(int Id)
        {
            var rooms = new List<RoomListViewModel>();
            rooms = GenerateAllVMs(Id);



            return rooms;
        }

        private List<RoomListViewModel> GenerateAllVMs(int Id)
        {
            var rooms = new List<RoomListViewModel>();
            foreach (var room in unit.RoomsForHotel.GetAllRoomsForHotelFull().Where(x => x.HotelId == Id))
            {
                rooms.Add(new RoomListViewModel()
                {
                    Description = room.Room.Roomdescription,
                    Name = unit.Rooms.GetRoomWithRoomSize(room.Room.RoomId).RoomSize.RoomSizeName,
                    Price = room.Room.RoomPrice,
                    Rating = GetRoomRating(Id),
                    Picture = GetRoomPicture(Id)
                });
            }

            return rooms;
        }

        private Picture GetRoomPicture(int id)
        {
            var picture = new Picture();
            //  throw new NotImplementedException();
            return picture;
        }

        private double GetRoomRating(int id)
        {
            var rooms = unit.RoomsForHotel.GetAll().Where(x => x.HotelId == id).ToList();
            var bookings = new List<Booking>();
            foreach (var room in rooms)
            {
                var booking = new Booking();
                var _bookings = unit.Bookings.GetBookings().ToList();
                booking = _bookings.FirstOrDefault<Booking>(x => x.RoomId == room.RoomId);
                bookings.Add(booking);
            }
            double avg;
            double total = avg = 0;
            foreach (var booking in bookings)
            {
                try
                {
                    total += double.Parse(unit.ReviewsForBooking.GetAll().FirstOrDefault(x => x.BookingId == booking.BookingId).Review.ReviewScore);

                }
                catch (Exception)
                {


                }
            }
            try
            {
                avg = total / bookings.Count;

            }
            catch
            {

            }


            return avg;
        }
    }
}
