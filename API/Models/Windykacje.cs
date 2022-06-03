using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Windykacje
    {
        public int IdWindykacje { get; set; }
        public int? AktywnaZakladka { get; set; }
        public DateTime? DataSprawy { get; set; }
        public string NrSprawy { get; set; }
        public int? NrSprawyKolejny { get; set; }
        public int? NrSprawyRok { get; set; }
        public int? NrSprawyMiesiac { get; set; }
        public string Lokalizacja { get; set; }
        public string DluznikSymbol { get; set; }
        public int? DluznikId { get; set; }
        public string DluznikNazwa { get; set; }
        public string DluznikAdres { get; set; }
        public string DluznikMiasto { get; set; }
        public string DluznikKod { get; set; }
        public string DluznikKraj { get; set; }
        public string DluznikNip { get; set; }
        public string DluznikTel { get; set; }
        public string DluznikFax { get; set; }
        public string DluznikEmail { get; set; }
        public string DluznikKont { get; set; }
        public string DluznikUwagi { get; set; }
        public string WindSchemat { get; set; }
        public int? WindSchematId { get; set; }
        public string Rodzaj { get; set; }
        public string Status { get; set; }
        public string Windykator { get; set; }
        public int? WindykatorId { get; set; }
        public string PracOdpow { get; set; }
        public int? PracOdpowId { get; set; }
        public string Sad { get; set; }
        public int? SadId { get; set; }
        public string KomornikSadowy { get; set; }
        public int? KomornikSadowyId { get; set; }
        public string Uwagi { get; set; }
        public int? Zalaczniki { get; set; }
        public string Waluta { get; set; }
        public double? Naleznosc { get; set; }
        public double? Odsetki { get; set; }
        public double? Wplaty { get; set; }
        public double? SaldoSprawy { get; set; }
        public string StatusZamkn { get; set; }
        public DateTime? DataZamkn { get; set; }
        public string OpisSprawy { get; set; }
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
        public string Dzial { get; set; }
    }
}
