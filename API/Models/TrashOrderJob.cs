using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TrashOrderJob
    {
        public int IdTrashOrderJob { get; set; }
        public int IdTrashOrder { get; set; }
        public int OrdIdPartner { get; set; }
        public DateTime? JobDate { get; set; }
        public string ContainerSymbol { get; set; }
        public string ContainerKind { get; set; }
        public int? QuantityPlanned { get; set; }
        public int? QuantityDone { get; set; }
        public string JobDescription { get; set; }
        public double? Price { get; set; }
        public short? IsNettoPrice { get; set; }
        public string ContainerSerialNumber { get; set; }
        public short? Done { get; set; }
        public DateTime? DoneDate { get; set; }
        public int? SequenceNumber { get; set; }
        public int WyjazdId { get; set; }
        public string SortKod { get; set; }
        public double? OpakRyczalt { get; set; }
        public int FakturaId { get; set; }
    }
}
