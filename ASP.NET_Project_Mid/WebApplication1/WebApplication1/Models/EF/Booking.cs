//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int FlatId { get; set; }
    
        public virtual Flat Flat { get; set; }
        public virtual User User { get; set; }
    }
}
