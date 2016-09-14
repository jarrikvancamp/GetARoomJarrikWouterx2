using GetARoom.BLL.WebAPI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GetARoom.BLL.ObjectHandlers;
using GetARoom.DAL.SpecificRepositories.UnitOfWork;
using GetARoom.DAL;
using System.Data.Entity;

namespace GetARoom.BLL.WebAPI.Models.Helpers
{
    public static class HotelHelper
    {
        private static HotelViewModel Hotel = new HotelViewModel();
        private static UnitOfWork unit = new UnitOfWork(new GetARoomEntities());
        private static List<HotelViewModel> Hotels = new List<HotelViewModel>();
        public static HotelViewModel GetHotelViewModel(int id)
        {
          //  GetPicture(id);
            GetHotelDetails(id);
            GetLocation(id);
            GetRating(id);
            return Hotel;
        }


        public static IEnumerable<HotelViewModel> GetAllHotels()
        {
            var hotels = unit.Hotels.GetAllHotelsWithLocation().ToList();
            foreach (var hotel in hotels)
            {
                Hotels.Add(GetHotelViewModel(hotel.HotelId));
            }

            return Hotels.ToList();
        }

        private static void GetRating(int id)
        {
          var reviews =  GetReviewsForHotel(id);
            var total = 0;
            foreach (var rev in reviews)
            {
                total += int.Parse(rev.ReviewScore.Trim());
            }
            if(reviews.Count()!= 0) { 
            var avg = total / reviews.Count();

            Hotel.Rating = avg;
            }
            else
            {
                Hotel.Rating = 3;
            }
        }

        private static void GetLocation(int id)
        {
            var _hotel = unit.Hotels.GetHotelWithLocation(id);
            Hotel.Location = _hotel.Location;

        }

        private static void GetHotelDetails(int id)
        {
            Hotel h = _RepositoryHandlerCollection.HotelHandler.GetById(id);
            Hotel.Name = h.HotelName;
            Hotel.Description = h.HotelDescription;
            Hotel.Phonenumber = h.Phonenumber;
        }

        private static void GetPicture(int id)
        {
            PictureForHotel pfh = unit.PicturesForHotel.GetPictureForHotelFullByHotelId(id);

            Hotel.Picture = pfh.Picture;

        }

        public static IEnumerable<Hotel> GetTopHotels(int amount)
        {
            var _hotels = unit.Hotels.GetAll().ToList();
            var bookings = new List<Booking>();
            foreach (var hotel in _hotels)
            {
                foreach (var rooms in GetListRooms(hotel.HotelId))
                {
                    foreach (var booking in GetListBooking(rooms.RoomId))
                    {
                        bookings.Add(booking);
                    }
                }
            }

            bookings.OrderBy(x => x.ReviewForBooking.OrderBy(y => y.Review.ReviewScore));
            var top = new List<Hotel>();

            for (int i = 0; i < amount; i++)
            {
                top.Add(_hotels[i]);
            }


            return top;
        }

        public static IEnumerable<Review> GetReviewsForHotel(int hotelId)
        {
            var bookings = new List<Booking>();
            var reviews = new List<Review>();
            foreach (var rooms in GetListRooms(unit.Hotels.GetById(hotelId).HotelId))
            {
                foreach (var booking in GetListBooking(rooms.RoomId))
                {
                    bookings.Add(booking);
                    foreach (var item in bookings)
                    {
                        try
                        {
                            var rfb = unit.ReviewsForBooking.GetReviewForBookingFull(item.BookingId);
                            reviews.Add(unit.Reviews.GetById(rfb.ReviewId));
                        }catch(Exception e){
                        }                                            
                    }
                }
            }
            return reviews;
        }

        private static Hotel GetHotelFromBooking(Booking booking)
        {
            var room = GetRoomFromBooking(booking);
            var hotel = GetHotelFromRoom(room);
            return hotel;
        }

        private static Hotel GetHotelFromRoom(Room room)
        {
            var rfh = unit.RoomsForHotel.GetRoomForHotelFull(room.RoomId);

            return rfh.Hotel;
        }

        private static Room GetRoomFromBooking(Booking booking)
        {
            var bookingwr = unit.Bookings.GetBookingWithRoom(booking.BookingId);

            var room = bookingwr.Room;
            return room;
        }

        private static IEnumerable<Booking> GetListBooking(int roomId)
        {
            var bookings = unit.Bookings.GetAll(roomId);

            return bookings;
        }

        private static IEnumerable<Room> GetListRooms(int hotelId)
        {

            var rooms = unit.Rooms.GetAllForHotel(hotelId);

            return rooms;
        }
    }
}