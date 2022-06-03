using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SentMsg
    {
        public int SentMsgId { get; set; }
        public int SentMainId { get; set; }
        public int? CtxObjId { get; set; }
        public int? CtxRecId { get; set; }
        public string SentMsg1 { get; set; }
        public int Type { get; set; }
        public int InOut { get; set; }
        public int? Lp { get; set; }
        public string SendXml { get; set; }
        public DateTime? SendDate { get; set; }
        public int? SendConfirmed { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
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
        public int? SentStatus { get; set; }
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
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string GeoLocatorNumber { get; set; }
        public string FailoverGeoLocatorNumber { get; set; }
        public string FailoverCarrierEmail { get; set; }
        public string ExitOtherPlace { get; set; }
        public string ExitProvince { get; set; }
        public double? ExitLatitude { get; set; }
        public double? ExitLongitude { get; set; }
        public string EntranceProvince { get; set; }
        public double? EntranceLatitude { get; set; }
        public double? EntranceLongitude { get; set; }
        public string EntranceOtherPlace { get; set; }
        public int? IsEntrance { get; set; }
        public int? IsExit { get; set; }
        public int? EntranceType { get; set; }
        public int? ExitType { get; set; }
        public int? Statement2 { get; set; }
        public int? Statement3 { get; set; }
        public int? Statement4 { get; set; }
        public int? Statement5 { get; set; }
        public int? Statement6 { get; set; }
        public int? Statement7 { get; set; }
    }
}
