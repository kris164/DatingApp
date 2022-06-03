using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PaczkiDokum
    {
        public int IdPaczkiDokum { get; set; }
        public int PrzesylkiDokumentyId { get; set; }
        public int PrzesylkiId { get; set; }
        public int PaczkiDokId { get; set; }
        public int PrzesylkiDokId { get; set; }
        public string PrzesylkiDokLok { get; set; }
        public double Ilosc { get; set; }
        public double IloscRozl { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public string Tryb { get; set; }
        public string KodDok { get; set; }
        public string Sticker { get; set; }
    }
}
