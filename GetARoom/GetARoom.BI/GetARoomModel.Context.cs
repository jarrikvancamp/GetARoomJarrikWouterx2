﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetARoom.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GetARoomEntities : DbContext
    {
        public GetARoomEntities()
            : base("name=GetARoomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Amenity> Amenity { get; set; }
        public virtual DbSet<AmenityForHotel> AmenityForHotel { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Creditcard> Creditcard { get; set; }
        public virtual DbSet<Geolocation> Geolocation { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentTypeForUser> PaymentTypeForUser { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<PictureForHotel> PictureForHotel { get; set; }
        public virtual DbSet<PictureForRoom> PictureForRoom { get; set; }
        public virtual DbSet<Postal> Postal { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<ReviewForBooking> ReviewForBooking { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<RoomAsset> RoomAsset { get; set; }
        public virtual DbSet<RoomSize> RoomSize { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<RoomForHotel> RoomForHotel { get; set; }
    }
}
