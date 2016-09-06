using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL
{
    public partial class Account : BaseEntity
    {

    }

    public partial class Address : BaseEntity
    {

    }
    public partial class Amenity : BaseEntity
    {

    }
    public partial class AmenityForHotel : BaseEntity
    {

    }
    public partial class Asset : BaseEntity
    {

    }
    public partial class Booking : BaseEntity
    {

    }
    public partial class Creditcard : BaseEntity
    {

    }
    public partial class Geolocation : BaseEntity
    {

    }
    public partial class Hotel : BaseEntity
    {

    }
    public partial class Location : BaseEntity
    {

    }
    public partial class Payment : BaseEntity
    {

    }
    public partial class PaymentTypeForUser : BaseEntity
    {

    }
    public partial class Person : BaseEntity
    {

    }
    public partial class Picture : BaseEntity
    {

    }
    public partial class PictureForHotel : BaseEntity
    {

    }
    public partial class PictureForRoom : BaseEntity
    {

    }
    public partial class Postal : BaseEntity
    {

    }
    public partial class Review : BaseEntity
    {

    }
    public partial class ReviewForBooking : BaseEntity
    {

    }
    public partial class Role : BaseEntity
    {

    }
    public partial class Room : BaseEntity
    {

    }
    public partial class RoomAsset : BaseEntity
    {

    }
    public partial class RoomForHotel : BaseEntity
    {
        [NotMapped]
        public int _FreeRoom { get; set; }



    }
    public partial class RoomSize : BaseEntity
    {

    }
    public partial class User : BaseEntity
    {

    }
    public partial class UserRoles : BaseEntity
    {

    }
}
