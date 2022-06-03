using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TrashOrder
    {
        public int IdTrashOrder { get; set; }
        public DateTime? TrashOrderDate { get; set; }
        public string Kind { get; set; }
        public string NrZlecenia { get; set; }
        public int? NrZleceniaKolejny { get; set; }
        public int? NrZleceniaRok { get; set; }
        public int? NrZleceniaMies { get; set; }
        public int? OrdIdPartner { get; set; }
        public string OrdSymbol { get; set; }
        public string OrdName { get; set; }
        public string OrdName2 { get; set; }
        public string OrdStreet { get; set; }
        public string OrdCity { get; set; }
        public string OrdZipCode { get; set; }
        public string OrdCountry { get; set; }
        public string OrdContact { get; set; }
        public string OrdTel { get; set; }
        public string OrdFax { get; set; }
        public string OrdEmail { get; set; }
        public string OrdVat { get; set; }
        public string OrdRemark { get; set; }
        public int? DstIdPartner { get; set; }
        public string DstSymbol { get; set; }
        public string DstName { get; set; }
        public string DstName2 { get; set; }
        public int AdresyId { get; set; }
        public string DstStreetType { get; set; }
        public string DstStreet { get; set; }
        public string DstStreetNumber { get; set; }
        public string DstInfo { get; set; }
        public string DstCity { get; set; }
        public string DstZipCode { get; set; }
        public string DstSortCode { get; set; }
        public string DstZone { get; set; }
        public string DstCommunity { get; set; }
        public string DstCountry { get; set; }
        public string DstContact { get; set; }
        public string DstTel { get; set; }
        public string DstFax { get; set; }
        public string DstEmail { get; set; }
        public string DstVat { get; set; }
        public string DstRemark { get; set; }
        public short? Periodic { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ScheduleSchema { get; set; }
        public string InvoiceText { get; set; }
        public int IsRyczalt { get; set; }
        public double? Ryczalt { get; set; }
        public int IsFakturaCykliczna { get; set; }
        public int? FakturaCyklicznaOkres { get; set; }
        public DateTime? FakturaCyklicznaLastDt { get; set; }
    }
}
