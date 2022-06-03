using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Contract
    {
        public int ContractId { get; set; }
        public int ContractStatusId { get; set; }
        public string Number { get; set; }
        public string ExternalNumber { get; set; }
        public string ContractNumber { get; set; }
        public string AdviceNumber { get; set; }
        public int? ContractTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? ClientId { get; set; }
        public int? ProductId { get; set; }
        public string Product { get; set; }
        public double? Amount { get; set; }
        public int? AmountUnitId { get; set; }
        public int? IncotermsId { get; set; }
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
        public decimal? EstimatedFreightRate { get; set; }
        public decimal? FreightRate { get; set; }
        public double? EstimatedDistance { get; set; }
        public double? Distance { get; set; }
        public int? IssuePersonId { get; set; }
        public int? LocalizationId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? EditUserId { get; set; }
        public string EditUser { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
