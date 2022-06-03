using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Harmonogramy
    {
        public int IdHarmonogramy { get; set; }
        public string Kod { get; set; }
        public string Status { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public int? MiejsceTyp { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
        public string MiejsceSymbol { get; set; }
        public string RodzajMiejsca { get; set; }
        public string CennikWg { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string Uwagi { get; set; }
        public DateTime? UtwOd { get; set; }
        public DateTime? UtwDo { get; set; }
        public int? ProcWyk { get; set; }
        public int? Wygenerowany { get; set; }
        public string MiejsceAdres { get; set; }
        public string MiejsceMiasto { get; set; }
        public string MiejsceKod { get; set; }
        public string MiejsceKraj { get; set; }
        public string MiejsceNazwa { get; set; }
    }
}
