using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiDokumenty
    {
        public int IdPrzesylkiDokumenty { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? Lp { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int? Wymagany { get; set; }
        public int? Wplynal { get; set; }
        public DateTime? DataWplywu { get; set; }
        public string Uzytkownik { get; set; }
        public string Uwagi { get; set; }
        public int? Rod { get; set; }
        public string RodDo { get; set; }
        public int? RodWyszedl { get; set; }
        public DateTime? RodDataWyjscia { get; set; }
        public string RodUzytkownik { get; set; }
        public int? KonsolidacjaId { get; set; }
        public int? PrzesylkiZwrId { get; set; }
        public string KodKreskowy { get; set; }
        public int? KwitPalId { get; set; }
        public int? Ilosc { get; set; }
        public int? IloscRozl { get; set; }
        public string LokalizacjaWejscia { get; set; }
        public string Lokalizacja { get; set; }
        public int? Dok { get; set; }
        public int? Doks { get; set; }
        public int? Erod { get; set; }
        public int? RodDoKontrahId { get; set; }
        public string RodDoKontrah { get; set; }
        public string Sticker { get; set; }
        public string LokalizacjaWyjscia { get; set; }
        public DateTime? DataWysCentr { get; set; }
        public int? SzufladaId { get; set; }
        public string Szuflada { get; set; }
        public string StopWLokalizacji { get; set; }
        public string Status { get; set; }
        public DateTime? DataOdbCentrala { get; set; }
        public DateTime? CzasOdbCentr { get; set; }
        public DateTime? DataDoSkanowania { get; set; }
        public DateTime? DataZSkanowania { get; set; }
        public DateTime? DataWyslaniaDoKlienta { get; set; }
        public int? Ekspres { get; set; }
        public string LogLokalizacja { get; set; }
        public DateTime? LogDataOdbCentrala { get; set; }
        public string UzytkownikPotw { get; set; }
    }
}
