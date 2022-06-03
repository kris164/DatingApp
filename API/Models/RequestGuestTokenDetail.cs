using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestGuestTokenDetail
    {
        public int RequestGuestTokenDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? OrderPointId { get; set; }
        public byte[] GuestHash { get; set; }
        public int? CarrierId { get; set; }
        public string Link { get; set; }
        public string Typ { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? GodzDo { get; set; }
        public DateTime? InsertDate { get; set; }
        public string Email { get; set; }
        public int? Sent { get; set; }
        public DateTime? SentDate { get; set; }
        public int? Active { get; set; }
        public int? ObjType { get; set; }
        public string HashString { get; set; }
    }
}
