﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZsPwZamkniecie
    {
        public int Id { get; set; }
        public int? SidId { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public int? PoleDod1 { get; set; }
        public string PoleDod2 { get; set; }
        public string PoleDod3 { get; set; }
        public DateTime? PoleDod4 { get; set; }
        public DateTime? PoleDod5 { get; set; }
        public string PoleDod6 { get; set; }
        public int? Gdpr { get; set; }
    }
}
