using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZzzPrzekazaniePojazdu
    {
        public DateTime? DataPrzekazania { get; set; }
        public string Ciagnik { get; set; }
        public int? CiagnikId { get; set; }
        public string Naczepa { get; set; }
        public int? NaczepaId { get; set; }
        public string KierowcaZdajacy { get; set; }
        public int? KierowcaZdajacyId { get; set; }
        public string KierowcaPobierajacy { get; set; }
        public int? KierowcaPobierajacyId { get; set; }
        public string WydalPolecenie { get; set; }
        public string Nadzorujacy { get; set; }
        public double? PasyKrzyzowe { get; set; }
        public double? PasyLadunkowe { get; set; }
        public double? Maty { get; set; }
        public double? Narozniki { get; set; }
        public double? Drabina { get; set; }
        public double? Belka { get; set; }
        public double? Apteczka { get; set; }
        public double? Gasnica { get; set; }
        public double? Kliny { get; set; }
        public double? KluczDoKol { get; set; }
        public double? KoloZpCiagik { get; set; }
        public double? KoloZpNaczepa { get; set; }
        public double? Lancuch { get; set; }
        public double? Lampka { get; set; }
        public double? KluczeKpl { get; set; }
        public double? Miotla { get; set; }
        public double? PistoletDoPrzedmuch { get; set; }
        public double? PistoletManometr { get; set; }
        public double? PrzewodPowietrzny { get; set; }
        public double? Podnosnik { get; set; }
        public double? Radio { get; set; }
        public double? RadioCb { get; set; }
        public double? Trojkat { get; set; }
        public double? GoboxShell { get; set; }
        public double? Viatoll { get; set; }
        public double? Premid { get; set; }
        public double? GoAustria { get; set; }
        public string Uwagi { get; set; }
        public double? CertyfikatL { get; set; }
        public double? CertyfikatEuro { get; set; }
        public double? KartaShell { get; set; }
        public double? KartaIds { get; set; }
        public double? Polisa { get; set; }
        public double? DowRej { get; set; }
        public double? KsiazkaGwar { get; set; }
        public double? Licencja { get; set; }
        public double? UpoLeasing { get; set; }
        public double? KartaTollColect { get; set; }
        public string UwagiDok { get; set; }
        public string CzyUszkodzenia { get; set; }
        public string Uszkodzenia { get; set; }
        public string InneUszkodzenia { get; set; }
        public string UszkodezeniaInne { get; set; }
        public int? Skaner { get; set; }
    }
}
