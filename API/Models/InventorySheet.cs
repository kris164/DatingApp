using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class InventorySheet
    {
        public int InventorySheetId { get; set; }
        public string InventoryNumber { get; set; }
        public int InventoryStatusId { get; set; }
        public int? InventoryYear { get; set; }
        public int? InventoryMonth { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? LocalizationId { get; set; }
        public int? DepartmentId { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? EditUserId { get; set; }
        public string EditUser { get; set; }
        public DateTime EditDate { get; set; }
    }
}
