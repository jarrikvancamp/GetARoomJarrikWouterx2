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
    
    public partial class RoomAsset
    {
        public int RoomAssetId { get; set; }
        public int AssetId { get; set; }
        public int RoomId { get; set; }
    
        public virtual Asset Asset { get; set; }
        public virtual Room Room { get; set; }
    }
}