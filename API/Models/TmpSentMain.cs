using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpSentMain
    {
        public int TmpSentMainId { get; set; }
        public int? SentMainId { get; set; }
        public int? SessionId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public string SentNumber { get; set; }
        public string SenderKey { get; set; }
        public string RecipientKey { get; set; }
        public string CarrierKey { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Creator { get; set; }
        public DateTime? ModificationData { get; set; }
        public string Modifier { get; set; }
        public string SentId { get; set; }
        public string SourceDocumentId { get; set; }
        public string ChecksumOfSourceDocument { get; set; }
        public string IncomingNumber { get; set; }
        public int? SentStatus { get; set; }
        public string GoodsCodeCnClassification { get; set; }
        public string GoodsCodePkwiuClassification { get; set; }
        public string GoodsName { get; set; }
        public double? GoodsAmount { get; set; }
        public string GoodsUnitOfMeasure { get; set; }
        public double? GoodsGrossWeightOfGoods { get; set; }
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
        public int? EmergencyProcedure { get; set; }
        public DateTime? StartTransportDate { get; set; }
        public DateTime? EndTransportDate { get; set; }
        public int? TypeOfTransport { get; set; }
        public string GeoLocatorNumber { get; set; }
        public string FailoverGeoLocatorNumber { get; set; }
        public string FailoverCarrierEmail { get; set; }
        public int? TypeOfDeclaration { get; set; }
    }
}
