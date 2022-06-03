using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ContractOrderSchedule
    {
        public int ContractOrderScheduleId { get; set; }
        public int? ContractOrderId { get; set; }
        public int? FtlId { get; set; }
        public DateTime? CollectDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double? OrderAmount { get; set; }
        public int? OrderAmountUnitId { get; set; }
        public int? TruckId { get; set; }
        public string TruckRegistractionNumber { get; set; }
        public int? SemitrailerId { get; set; }
        public string SemitrailerRegistractionNumber { get; set; }
        public string DriverMobile { get; set; }
        public string DriverName { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? EditUserId { get; set; }
        public string EditUser { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
