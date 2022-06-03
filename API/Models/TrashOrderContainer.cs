using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TrashOrderContainer
    {
        public int IdTrashOrderContainer { get; set; }
        public int IdTrashOrder { get; set; }
        public int OrdIdPartner { get; set; }
        public string ContainerSymbol { get; set; }
        public string ContainerKind { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public short? IsNettoPrice { get; set; }
    }
}
