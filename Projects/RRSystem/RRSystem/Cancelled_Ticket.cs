//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cancelled_Ticket
    {
        public decimal Canceled_id { get; set; }
        public decimal PNR_No { get; set; }
        public decimal User_id { get; set; }
        public decimal Train_No { get; set; }
        public System.DateTime Cancellation_Date_Time { get; set; }
        public double Refund_Ammount { get; set; }
    
        public virtual Booked_Ticket Booked_Ticket { get; set; }
        public virtual Train_Details Train_Details { get; set; }
        public virtual User_details User_details { get; set; }
    }
}
