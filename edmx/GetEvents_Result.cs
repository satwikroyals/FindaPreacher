//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindaPreacher_1_.edmx
{
    using System;
    
    public partial class GetEvents_Result
    {
        public long EventID { get; set; }
        public long UserID { get; set; }
        public string Title { get; set; }
        public string MinistryTypeID { get; set; }
        public string HelpServiceTypeIDs { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmailID { get; set; }
        public int IsBookingNeeded { get; set; }
        public string TicketPrice { get; set; }
        public long TicketsAvailable { get; set; }
        public long TicketsPerPerson { get; set; }
        public long TicketsBooked { get; set; }
        public Nullable<int> Status { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int IsFavouriteEvent { get; set; }
    }
}
