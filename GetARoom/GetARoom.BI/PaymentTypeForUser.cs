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
    
    public partial class PaymentTypeForUser
    {
        public int PaymentTyperForUserId { get; set; }
        public int CreditcardId { get; set; }
        public int UserId { get; set; }
    
        public virtual Creditcard Creditcard { get; set; }
        public virtual User User { get; set; }
    }
}
