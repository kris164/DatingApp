using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPromy
    {
        public int IdTmpPromy { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public DateTime? Data { get; set; }
        public int? ArmatorId { get; set; }
        public string Armator { get; set; }
        public int? RelacjaId { get; set; }
        public string Relacja { get; set; }
        public string RelacjaSymbol { get; set; }
        public DateTime? DataWypl { get; set; }
        public DateTime? GodzWypl { get; set; }
        public DateTime? DataWjazd { get; set; }
        public DateTime? GodzWjazd { get; set; }
        public DateTime? DataZjazd { get; set; }
        public DateTime? GodzZjazd { get; set; }
        public int? SamOsob { get; set; }
        public int? Adr { get; set; }
        public double? DlugoscMb { get; set; }
        public int? Kierowcy { get; set; }
        public double? PonadgabarytDl { get; set; }
        public double? PonadgabarytWy { get; set; }
        public double? PonadgabarytSz { get; set; }
        public int? Agregat { get; set; }
        public double? IloscTon { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? Tydzien { get; set; }
        public string DzienTyg { get; set; }
        public string KlasaAdr { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string KosztyRazemWal { get; set; }
        public string KlientKwotaWal { get; set; }
        public double? KlientKwota { get; set; }
        public int? IdPromy { get; set; }
        public string KosztyRazemWalFv { get; set; }
        public string KlientKwotaWalFv { get; set; }
        public double? DlugoscMb2 { get; set; }
        public string Usluga { get; set; }
        public int? Papier { get; set; }
    }
}
