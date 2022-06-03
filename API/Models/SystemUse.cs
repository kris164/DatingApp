using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SystemUse
    {
        public int IdSystemUse { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Czas { get; set; }
        public string Identyfikator { get; set; }
        public string Osoba { get; set; }
        public string Program { get; set; }
        public string ProgramLogin { get; set; }
        public string ProgramOsoba { get; set; }
        public string IpAdres { get; set; }
        public string Komputer { get; set; }
        public string Uzytkownik { get; set; }
        public string UzytkownikOsoba { get; set; }
        public string Mac { get; set; }
        public string Windows { get; set; }
        public int? Licencja { get; set; }
        public int? System { get; set; }
        public byte[] Moduly { get; set; }
        public byte[] Uzytemoduly { get; set; }
    }
}
