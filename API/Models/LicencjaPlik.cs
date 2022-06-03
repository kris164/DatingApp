using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LicencjaPlik
    {
        public int IdLicencjaPlik { get; set; }
        public string Stanowisko { get; set; }
        public int ProfilId { get; set; }
        public int Terminal { get; set; }
        public int UzytkownikId { get; set; }
        public string UzytkownikNazwa { get; set; }
        public DateTime Dataczas { get; set; }
    }
}
