//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIT5032_AssignmentPortfolio_Ver1._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int BookingId { get; set; }
        public int Value { get; set; }
        public string Feedback { get; set; }
    
        public virtual Booking Booking { get; set; }
    }
}