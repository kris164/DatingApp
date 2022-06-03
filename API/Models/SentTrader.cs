using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SentTrader
    {
        public int SentTraderId { get; set; }
        public int SentMainId { get; set; }
        public string Type { get; set; }
        public string IdSisc { get; set; }
        public string TraderName { get; set; }
        public string TraderIdentityType { get; set; }
        public string TraderIdentityNumber { get; set; }
        public DateTime? PlannedStartCarriageDate { get; set; }
        public int? TraderId { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }
        public string NumberOfLicense { get; set; }
        public string AuthorityName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Province { get; set; }
        public string OilHeatingAddressId { get; set; }
    }
}
