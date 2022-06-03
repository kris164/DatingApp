using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AuctionHistory
    {
        public int AuctionHistoryId { get; set; }
        public int AuctionId { get; set; }
        public DateTime OfferDate { get; set; }
        public double Value { get; set; }
        public int CarrierId { get; set; }
        public int UserId { get; set; }
        public int Accepted { get; set; }
        public int Canceled { get; set; }
        public int BuyNow { get; set; }
        public string Descriptions { get; set; }
    }
}
