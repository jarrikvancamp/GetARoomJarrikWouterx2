using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public static class _RepositoryHandlerCollection
    {

        public static HotelHandler HotelHandler = new HotelHandler(new UnitOfWork(new GetARoomEntities()));

        public static AccountHandler AccountHandler = new AccountHandler(new Repository<Account>(new GetARoomEntities()));
        public static AddressHandler AddressHandler = new AddressHandler(new Repository<Address>(new GetARoomEntities()));
        public static AmenityHandler AmenityHandler = new AmenityHandler(new Repository<Amenity>(new GetARoomEntities()));
        public static AssetHandler AssetHandler = new AssetHandler(new Repository<Asset>(new GetARoomEntities()));
        public static BookingHandler BookingHandler = new BookingHandler(new Repository<Booking>(new GetARoomEntities()));
        public static CreditcardHandler CreditcardHandler = new CreditcardHandler(new Repository<Creditcard>(new GetARoomEntities()));
        public static GeolocationHandler GeolocationHandler = new GeolocationHandler(new Repository<Geolocation>(new GetARoomEntities()));
                
        public static LocationHandler LocationHandler = new LocationHandler(new Repository<Location>(new GetARoomEntities()));
        public static PaymentHandler PaymentHandler = new PaymentHandler(new Repository<Payment>(new GetARoomEntities()));
        public static PersonHandler PersonHandler = new PersonHandler(new Repository<Person>(new GetARoomEntities()));
        public static PictureHandler PictureHandler = new PictureHandler(new Repository<Picture>(new GetARoomEntities()));
        public static PostalHandler PostalHandler = new PostalHandler(new Repository<Postal>(new GetARoomEntities()));
        public static ReviewHandler ReviewHandler = new ReviewHandler(new Repository<Review>(new GetARoomEntities()));
        public static RoleHandler RoleHandler = new RoleHandler(new Repository<Role>(new GetARoomEntities()));
        public static RoomHandler RoomHandler = new RoomHandler(new Repository<Room>(new GetARoomEntities()));
        public static RoomSizeHandler RoomSizeHandler = new RoomSizeHandler(new Repository<RoomSize>(new GetARoomEntities()));
        public static UserHandler UserHandler = new UserHandler(new Repository<User>(new GetARoomEntities()));





    }
}
