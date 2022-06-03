using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Oferty
    {
        public int IdOferty { get; set; }
        public string NrOferty { get; set; }
        public int? NrOfertyKolejny { get; set; }
        public int? NrOfertyRok { get; set; }
        public int? NrOfertyMies { get; set; }
        public string JezykOferty { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public string TypZlecenia { get; set; }
        public DateTime? DataOferty { get; set; }
        public DateTime? DataZaladunku { get; set; }
        public DateTime? GodzZaladunku { get; set; }
        public DateTime? DataRozladunku { get; set; }
        public DateTime? GodzRozladunku { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientMiasto { get; set; }
        public string KlientKod { get; set; }
        public string KlientKraj { get; set; }
        public string KlientNip { get; set; }
        public string KlientOsobaKont { get; set; }
        public int? MiejsceZaladunkuId { get; set; }
        public int? MiejsceRozladunkuId { get; set; }
        public string MiejsceZaladunku { get; set; }
        public string MiejsceRozladunku { get; set; }
        public string KrajZaladunku { get; set; }
        public string KrajRozladunku { get; set; }
        public int? TrasaId { get; set; }
        public string Trasa { get; set; }
        public double? TrasaOdl { get; set; }
        public string InfoDod { get; set; }
        public string OpisTowaru { get; set; }
        public double? WagaLadunku { get; set; }
        public double? ObjetoscLadunku { get; set; }
        public double? Wysokosc { get; set; }
        public double? Szerokosc { get; set; }
        public double? Dlugosc { get; set; }
        public string TypOpakowania { get; set; }
        public double? IloscOpakowan { get; set; }
        public int? Adr { get; set; }
        public string AdrInfo { get; set; }
        public double? Kwota { get; set; }
        public double? KwotaP { get; set; }
        public string Waluta { get; set; }
        public string FormaPlatnosci { get; set; }
        public int? Termin { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public int? PrzewoznikId { get; set; }
        public string PrzewoznikNazwa { get; set; }
        public double? Marza { get; set; }
        public string Status { get; set; }
        public DateTime? DataZlozenia { get; set; }
        public string SposobZlozenia { get; set; }
        public string Lokalizacja { get; set; }
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
        public int? Zalaczniki { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public string KlientOsobaTelfax { get; set; }
        public string KlientOsobaEmail { get; set; }
        public DateTime? DataWaznOferty { get; set; }
        public int? MinTermAwizacji { get; set; }
        public int? TrafikId { get; set; }
        public string Trafik { get; set; }
        public string Dzial { get; set; }
        public string Dotyczy { get; set; }
        public DateTime? DataWaznWyceny { get; set; }
    }
}
