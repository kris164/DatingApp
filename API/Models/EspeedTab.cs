using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EspeedTab
    {
        public int IdEspeedTabs { get; set; }
        public int? EspeedDsId { get; set; }
        public int? FieldsNr { get; set; }
        public string TabName { get; set; }
        public string ImageUrl { get; set; }
        public int? OnlyAuthorized { get; set; }
    }
}
