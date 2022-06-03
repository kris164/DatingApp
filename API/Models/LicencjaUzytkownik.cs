using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LicencjaUzytkownik
    {
        public int IdLicencjaUzytkownik { get; set; }
        public int ProfilId { get; set; }
        public int UzytkownikId { get; set; }
        public string Hash { get; set; }
    }
}
