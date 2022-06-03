using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DaneAwb
    {
        public int IdDaneAwb { get; set; }
        public int ObjId { get; set; }
        public int RecId { get; set; }
        /// <summary>
        /// MAWB/HAWB
        /// </summary>
        public string TypDok { get; set; }
        public string Numbers1 { get; set; }
        public string Numbers2 { get; set; }
        public int? ShipperId { get; set; }
        public string ShipperSymbol { get; set; }
        public string Shipper { get; set; }
        public int? ConsigneeId { get; set; }
        public string ConsigneeSymbol { get; set; }
        public string Consignee { get; set; }
        public int? AgentId { get; set; }
        public string AgentSymbol { get; set; }
        public string Agent { get; set; }
        public string AgentIata { get; set; }
        public string AgentAccount { get; set; }
        public int? WaybillId { get; set; }
        public string WaybillSymbol { get; set; }
        public string Waybill { get; set; }
        public string AccountInfo { get; set; }
        public string AirportOfDeparture { get; set; }
        public string Routing { get; set; }
        public string To1 { get; set; }
        public string By1 { get; set; }
        public string To2 { get; set; }
        public string By2 { get; set; }
        public string To3 { get; set; }
        public string By3 { get; set; }
        public string AirportOfDestination { get; set; }
        public string Flight1 { get; set; }
        public string Flight2 { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Curr { get; set; }
        public string WtVal { get; set; }
        public string Other { get; set; }
        public string DeclValCarr { get; set; }
        public string DeclValCust { get; set; }
        public string AmountOfInsurance { get; set; }
        public string HandlingInfo { get; set; }
        public string Sci { get; set; }
        public string NatureOfGoods { get; set; }
        public string Notes { get; set; }
        public string WeightCharge1 { get; set; }
        public string WeightCharge2 { get; set; }
        public double? ValCharge1 { get; set; }
        public double? ValCharge2 { get; set; }
        public double? Tax1 { get; set; }
        public double? Tax2 { get; set; }
        public double? TotalA1 { get; set; }
        public double? TotalA2 { get; set; }
        public double? TotalC1 { get; set; }
        public double? TotalC2 { get; set; }
        public string TotalPrepaid { get; set; }
        public string TotalCollect { get; set; }
        public double? CurrConvRate { get; set; }
        public string Signature { get; set; }
        public DateTime? ExecutedOn { get; set; }
        public string AtPlace { get; set; }
        public string SignatureUser { get; set; }
    }
}
