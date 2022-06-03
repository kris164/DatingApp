using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapCatalogDetail
    {
        public int MapCatalogDetailId { get; set; }
        public int MapCatalogId { get; set; }
        public int OrdinalNumber { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
        public string Role { get; set; }
    }
}
