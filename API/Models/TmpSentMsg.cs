using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpSentMsg
    {
        public int TmpSentMsgId { get; set; }
        public int? SessionId { get; set; }
        public int? SentMsgId { get; set; }
        public int? SentMainId { get; set; }
        public int? CtxObjId { get; set; }
        public int? CtxRecId { get; set; }
        public string SentMsg { get; set; }
        public int? Type { get; set; }
        public int? InOut { get; set; }
        public int? Lp { get; set; }
        public string SendXml { get; set; }
        public DateTime? SendDate { get; set; }
        public int? SendConfirmed { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? CarrierId { get; set; }
        public string CarrierIdSisc { get; set; }
        public string CarrierName { get; set; }
        public string CarrierIdentityType { get; set; }
        public string CarrierIdentityNumber { get; set; }
        public string CarrierStreet { get; set; }
        public string CarrierHouseNumber { get; set; }
        public string CarrierFlatNumber { get; set; }
        public string CarrierCity { get; set; }
        public string CarrierCountry { get; set; }
        public string CarrierPostalCode { get; set; }
        public DateTime? StartTransportDate { get; set; }
        public DateTime? EndTransportDate { get; set; }
        public string GoodsTypeOfTransportDocument { get; set; }
        public string GoodsNumberOfTransportDocument { get; set; }
        public string MeansOfTransportTruckNumber { get; set; }
        public string MeansOfTransportTrailerNumber { get; set; }
        public string MeansOfTransportPermitRoad { get; set; }
        public string EntranceRoutePlace { get; set; }
        public string EntranceRouteNumber { get; set; }
        public DateTime? EntranceDate { get; set; }
        public string ExitRoutePlace { get; set; }
        public string ExitRouteNumber { get; set; }
        public DateTime? ExitDate { get; set; }
        public string Comments { get; set; }
        public string DocumentId { get; set; }
        public string ResponseEmailAddress1 { get; set; }
        public string ResponseEmailAddress2 { get; set; }
        public string ResponseEmailAddress3 { get; set; }
        public int? Statement { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ComplianceIsCompliance { get; set; }
        public string ComplianceTypeOfNonCompliance { get; set; }
        public DateTime? CloseTransportDate { get; set; }
        public string ErrorText { get; set; }
    }
}
