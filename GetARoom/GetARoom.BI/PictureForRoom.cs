//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PictureForRoom
    {
        public int PictureForRoomId { get; set; }
        public int PictureId { get; set; }
        public int RoomId { get; set; }
    
        public virtual Picture Picture { get; set; }
        public virtual Room Room { get; set; }
    }
}
