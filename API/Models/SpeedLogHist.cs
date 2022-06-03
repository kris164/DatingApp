using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SpeedLogHist
    {
        public int IdSpeedLogHist { get; set; }
        public string Stanowisko { get; set; }
        public int? Terminal { get; set; }
        public int? UzytkownikId { get; set; }
        public string UzytkownikLogin { get; set; }
        public string UzytkownikNazwa { get; set; }
        public DateTime? Dataczas { get; set; }
        public string KomputerNazwa { get; set; }
        public string KomputerIp { get; set; }
        public string ProgramKatalog { get; set; }
        public string ProgramNazwa { get; set; }
        public string ProgramWersja { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string Baza { get; set; }
        public string Licencja { get; set; }
    }
}
