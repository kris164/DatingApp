using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class InventorySheetPosition
    {
        public int InventorySheetPositionId { get; set; }
        public int InventorySheetId { get; set; }
        public int ShipmentId { get; set; }
        public int PackageId { get; set; }
        public string Package { get; set; }
        public int Scan { get; set; }
        public int Stock { get; set; }
        public int ScanUserId { get; set; }
        public string ScanUser { get; set; }
        public DateTime? ScanDate { get; set; }
    }
}
