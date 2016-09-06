using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IUnitOfWork
    {
        IHotelRepository Hotels { get; }
        IBookingRepository Bookings { get; }
        ILocationRepository Locations { get; }
        IAddressRepository Addresses { get; }
        IAmenityForHotel AmenitiesForHotels { get; }
        IPaymentRepository Payments { get; }
        IPaymentForUserRepository PaymentsForUser { get; }
        IPictureForHotelRepository PicturesForHotel { get; }
        IPictureForRoomRepository PicturesForRoom { get; }
        IReviewRepository Reviews { get; }
        IReviewForBookingRepository ReviewsForBooking { get; }
        IRoomRepository Rooms { get; }
        IRoomAssetRepository RoomAssets { get; }
        IRoomForHotelRepository RoomsForHotel { get; }
    }
}
