using GetARoom.DAL.SpecificRepositories.Interfaces;
using GetARoom.DAL.SpecificRepositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public IHotelRepository Hotels { get; private set; }

        public IBookingRepository Bookings { get; private set; }
        public ILocationRepository Locations { get; private set; }
        public IAddressRepository Addresses { get; private set; }
        public IPaymentRepository Payments { get; private set; }
        public IAmenityForHotel AmenitiesForHotels { get; private set; }
        public IPaymentForUserRepository PaymentsForUser { get; private set; }
        public IPictureForHotelRepository PicturesForHotel { get; private set; }
        public IPictureForRoomRepository PicturesForRoom { get; private set; }
        public IReviewRepository Reviews { get; private set; }
        public IReviewForBookingRepository ReviewsForBooking { get; private set; }
        public IRoomRepository Rooms { get; private set; }
        public IRoomAssetRepository RoomAssets { get; private set; }
        public IRoomForHotelRepository RoomsForHotel { get; private set; }

        protected readonly GetARoomEntities _db;

        public UnitOfWork(GetARoomEntities db)
        {

            _db = db;

            Hotels = new HotelRepository(_db);
            Bookings = new BookingRepository(_db);
            Locations = new LocationRepository(_db);
            Addresses = new AddressRepository(_db);
            AmenitiesForHotels = new AmenityForHotelRepository(_db);
            PaymentsForUser = new PaymentForUserRepository(_db);
            PicturesForHotel = new PictureForHotelRepository(_db);
            PicturesForRoom = new PictureForRoomRepository(_db);
            Reviews = new ReviewRepository(_db);
            ReviewsForBooking = new ReviewForBookingRepository(_db);
            Rooms = new RoomRepository(_db);
            RoomAssets = new RoomAssetRepository(_db);
            RoomsForHotel = new RoomForHotelRepository(_db);

        }


    }
}
