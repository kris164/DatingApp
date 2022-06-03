using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AdrZestawSprzet
    {
        public int IdAdrZestawSprzet { get; set; }
        public int AdrSprzetId { get; set; }
        public string AdrSprzet { get; set; }
        public int AdrZestawId { get; set; }
    }
}
