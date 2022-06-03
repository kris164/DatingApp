using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Auction
    {
        public int AuctionId { get; set; }
        public int ObjectId { get; set; }
        public int RecordId { get; set; }
        public int Type { get; set; }
        public string Currency { get; set; }
        public double StartValue { get; set; }
        public double? BuyNowValue { get; set; }
        public double BiddingStep { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int Canceled { get; set; }
        public string Descriptions { get; set; }
    }
}
