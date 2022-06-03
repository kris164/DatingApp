using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DataExchange
    {
        public int DataExchangeId { get; set; }
        public int? LocalIndex { get; set; }
        public int? RemoteIndex { get; set; }
        public int? ExchangeState { get; set; }
        public int? ObjectId { get; set; }
    }
}
