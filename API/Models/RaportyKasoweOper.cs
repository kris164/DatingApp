using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RaportyKasoweOper
    {
        public int IdRaportyKasoweOper { get; set; }
        public int? NrOperacji { get; set; }
        public string DowodNr { get; set; }
        public int? DowodKolejny { get; set; }
        public int? DowodRok { get; set; }
        public int? DowodMies { get; set; }
        public int? RaportKasowyId { get; set; }
        public string RaportKasowy { get; set; }
        public string Rodzaj { get; set; }
        public string Typ { get; set; }
        public string Konto { get; set; }
        public string TypListyK { get; set; }
        public double? Kwota { get; set; }
        public double? KwotaPln { get; set; }
        public double? KursWymiany { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientKod { get; set; }
        public string KlientMiasto { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string Opis { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public int? ZaliczkaId { get; set; }
        public string Zaliczka { get; set; }
        public int? RozlZal { get; set; }
        public int? RozlCod { get; set; }
        public int? PrzesylkiId { get; set; }
        public string Przesylki { get; set; }
        public int Delegacja { get; set; }
        public int? Zal { get; set; }
        public double? RoznKursowa { get; set; }
        public int? KursUzgodniony { get; set; }
        public string WalutaB { get; set; }
        public int? KursyWalutBId { get; set; }
        public string NrTabeliKursowB { get; set; }
        public DateTime? DataTabeliKursowB { get; set; }
        public int? KursyWalutId { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public double? KursWalutyB { get; set; }
        public double? KursWaluty { get; set; }
        public double? KwotaB { get; set; }
        public string Info { get; set; }
        /// <summary>
        /// Relacja do użytkownika tworzącego rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? CreateIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika tworzącego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data utworzenia
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Godzina utworzenia
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Relacja do użytkownika który ostatni modyfikował rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? ModifyIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika modyfikującego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Godzina ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
