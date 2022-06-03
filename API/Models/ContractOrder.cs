using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ContractOrder
    {
        public int ContractOrderId { get; set; }
        public int? ContractOrderStatusId { get; set; }
        public int ContractId { get; set; }
        public int CarrierId { get; set; }
        public string Number { get; set; }
        public decimal? OrderValue { get; set; }
        public decimal? EstimatedFreightRate { get; set; }
        public decimal? FreightRate { get; set; }
        public double? OrderAmount { get; set; }
        public int? OrderAmountUnitId { get; set; }
        public DateTime? DeliveryDateStart { get; set; }
        public DateTime? DeliveryDateFinish { get; set; }
        public double? LoadCarryingCapacity { get; set; }
        public int? LoadCarryingCapacityUnitId { get; set; }
        public int? CollectId { get; set; }
        public string Collect { get; set; }
        public string CollectAddress { get; set; }
        public string CollectPostCode { get; set; }
        public string CollectCity { get; set; }
        public string CollectCountry { get; set; }
        public string CollectTelephone { get; set; }
        public string CollectContactPerson { get; set; }
        public int? DeliveryId { get; set; }
        public string Delivery { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryPostCode { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryTelephone { get; set; }
        public string DeliveryContactPerson { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? EditUserId { get; set; }
        public string EditUser { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
