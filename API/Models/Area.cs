using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Area
    {
        public int AreaId { get; set; }
        public int? ShapeTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Shape { get; set; }
        public int? Status { get; set; }
        public string Color { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
