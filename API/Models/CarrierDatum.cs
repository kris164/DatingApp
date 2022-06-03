using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CarrierDatum
    {
        public int CarrierDataId { get; set; }
        public int? CarrierId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Type { get; set; }
        public int? Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Lead { get; set; }
        public string Language { get; set; }
    }
}
