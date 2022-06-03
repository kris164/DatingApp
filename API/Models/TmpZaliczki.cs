using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZaliczki
    {
        public int IdTmpZaliczki { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdZaliczki { get; set; }
        public string NrZaliczki { get; set; }
        public int? NrZaliczkiKolejny { get; set; }
        public int? NrZaliczkiRok { get; set; }
        public int? NrZaliczkiMies { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public int? DelegacjaId { get; set; }
        public string Delegacja { get; set; }
        public int? PracownikId { get; set; }
        public string Pracownik { get; set; }
        public string WalutaZaliczki { get; set; }
        public double? KwotaZaliczki { get; set; }
        public double? KwotaWydanaU { get; set; }
        public double? KwotaWydanaN { get; set; }
        public double? DoZwrotuWyplaty { get; set; }
        public double? Wplacono { get; set; }
        public double? Saldo { get; set; }
        public int? Rozliczono { get; set; }
        public DateTime? DataRozliczenia { get; set; }
        public int? KursUzgodniony { get; set; }
        public int? KursyWalutId { get; set; }
        public string KursyWalut { get; set; }
        public double? Kurs { get; set; }
        public DateTime? KursyWalutData { get; set; }
        public string Lokalizacja { get; set; }
        public int? FormaWyplaty { get; set; }
        public int? Dieta { get; set; }
        public string Dzial { get; set; }
        public double? KwotaPln { get; set; }
        public string Uwagi { get; set; }
        public string Status { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
        public int? RapKasoweOperWyId { get; set; }
        public string RapKasoweOperWy { get; set; }
        public int? RapKasoweOperRozId { get; set; }
        public string RapKasoweOperRoz { get; set; }
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
