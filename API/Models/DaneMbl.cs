using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Opłaty dodatkowe MBL
    /// </summary>
    public partial class DaneMbl
    {
        public int IdDaneMbl { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public string TypDok { get; set; }
        public string AgentReference { get; set; }
        public string BookingNo { get; set; }
        public int? ShipperId { get; set; }
        public string ShipperSymbol { get; set; }
        public string Shipper { get; set; }
        public int? ConsigneeId { get; set; }
        public string ConsigneeSymbol { get; set; }
        public string Consignee { get; set; }
        public int? AgentId { get; set; }
        public string AgentSymbol { get; set; }
        public string Agent { get; set; }
        public int? NotifyId { get; set; }
        public string NotifySymbol { get; set; }
        public string Notify { get; set; }
        public int? NotifyExtId { get; set; }
        public string NotifyExtSymbol { get; set; }
        public string NotifyExt { get; set; }
        public int? IssuerId { get; set; }
        public string IssuerSymbol { get; set; }
        public string Issuer { get; set; }
        public int? ShipownerId { get; set; }
        public string ShipownerSymbol { get; set; }
        public string Shipowner { get; set; }
        public string PreCarriageBy { get; set; }
        public string PlaceOfReceipt { get; set; }
        public string Vessel { get; set; }
        public string PortOfLoading { get; set; }
        public string ExportReferences { get; set; }
        public string InternalReferences { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string FreightPayable { get; set; }
        public string PortOfDischarge { get; set; }
        public string PortOfTranshipment { get; set; }
        public string PointAndCountryOfOrigin { get; set; }
        public string TypeOfMove { get; set; }
        public string TempControlInstructions { get; set; }
        public string ExcessValueDeclaration { get; set; }
        public string AdditionalGoodsDescription { get; set; }
        public string FinalDestination { get; set; }
        public string AdditionalInformation { get; set; }
        public int? QntOfOrygin { get; set; }
    }
}
