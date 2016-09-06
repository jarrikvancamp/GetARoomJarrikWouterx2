

using GetARoom.DAL;


using GetARoom.BLL.ObjectHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GetARoom.DAL.SpecificRepositories.UnitOfWork;
using GetARoom.BLL.WebAPI.Models.Helpers;

namespace GetARoom.Test.Output
{
    public class TestMethods
    {
  

        #region Tests


        public void AddEntities()
        {
            //Person p = new Person
            //{
            //    PersondateOfBirth = DateTime.Now,
            //    Personemail = "aaaa@aa.be",
            //    PersonFirstname = "Jarrik",
            //    PersonLastname = "Van Camp"
            //};
            ////  db.PersonHandler.Add(p);

            //Account a = new Account()
            //{
            //    Password = "test",
            //    Username = "test"
            //};
            //db.AccountHandler.Add(a);

            //User u = new User
            //{
            //    PersonId = db.PersonHandler.GetById(1).PersonId,
            //    AccountId = db.AccountHandler.GetById(1).AccountId
            //};
            //db.UserHandler.Add(u);
        }

        public void testAdd()
        {
            //    foreach (var item in _RepositoryHandlerCollection.HotelHandler.GetAll())
            //    {
            //        Console.WriteLine(item.HotelName);
            //    }
        }


        public void addPostalCodes()
        {
            //foreach (string line in File.ReadLines(@"C:\Users\JaVC\Documents\Ordina\Kickstarter\000 Project\Get A Room\Documenten\postcodes.txt", Encoding.UTF8))
            //{
            //    Postal p = new Postal
            //    {
            //       PostalCode=  line.Split(' ')[0],
            //       Postalcity = line.Split(' ')[1]
            //    };

            //    Console.WriteLine(p.PostalCode +" " +p.Postalcity);
            //    db.PostalHandler.Add(p);
            //}
        }

        #endregion

        UnitOfWork unit = new UnitOfWork(new GetARoomEntities());

        //public void testBookingRepo()
        ////{
        ////    var a = unit.Bookings.GetAll().ToList();
        ////    foreach (var item in a)
        ////    {
        ////        Console.WriteLine(item.BookingDate);
        ////    }

        ////    a = unit.Bookings.GetAllBookingsWithRooms().ToList();
        ////    foreach (var item in a)
        ////    {
        ////        Console.WriteLine(item.BookingDate + " " + item.Room.Roomdescription);
        ////    }
        ////    a = unit.Bookings.GetAllBookingsWithUsers().ToList();
        ////    foreach (var item in a)
        ////    {
        ////        Console.WriteLine(item.BookingDate + " " + item.User.UserId);
        ////    }
        ////    a = unit.Bookings.GetBookings().ToList();
        ////    foreach (var item in a)
        ////    {
        ////        Console.WriteLine(item.BookingDate + " " + item.User.UserId + " " + item.Room.Roomdescription);
        ////    }

        ////    Console.WriteLine("----------");

        ////    var b = unit.Bookings.GetBookingWithRoom(1);

        ////    Console.WriteLine(b.BookingDate + "  " + b.Room.Roomdescription);

        //}

        //public void testHotelReviews()
        //{
        //    //var hotel = HotelHelper.GetHotelViewModel(1);

        //    //Console.WriteLine(hotel.Rating);
        //}

        public void testRating(int id)

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

            var bfr = new List<ReviewForBooking>();
            foreach (var booking in bookings)
            {

                try
                {
                    total += int.Parse(unit.ReviewsForBooking
                        .GetReviewForBookingFull(unit.ReviewsForBooking.GetAll()
                        .FirstOrDefault(x=>x.BookingId == booking.Id).Review.ReviewId)
                        .Review.ReviewScore);
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


            Console.WriteLine(avg.ToString());
        }

    }
}
