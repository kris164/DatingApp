using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKwitPal
    {
        public int IdTmpKwitPal { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Data kwitu
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Numer kwitu
        /// </summary>
        public string NrKp { get; set; }
        /// <summary>
        /// Numer kolejny z licznika
        /// </summary>
        public int? NrKpKolejny { get; set; }
        /// <summary>
        /// Rok z licznika
        /// </summary>
        public int? NrKpRok { get; set; }
        /// <summary>
        /// Miesiac z licznika
        /// </summary>
        public int? NrKpMies { get; set; }
        /// <summary>
        /// Numer ref. (np. nr dokumentu nadania)
        /// </summary>
        public string NrRfk { get; set; }
        /// <summary>
        /// Typ klienta 0 - odbiorca, 1 - przewoznik, 2 - nadawca
        /// </summary>
        public int? KlientTyp { get; set; }
        /// <summary>
        /// Relacja do klienta
        /// </summary>
        public int? KlientId { get; set; }
        /// <summary>
        /// Symbol klienta
        /// </summary>
        public string Klient { get; set; }
        /// <summary>
        /// Flaga, czy rozliczono
        /// </summary>
        public int? Rozliczony { get; set; }
        /// <summary>
        /// Data rozliczenia kwitu
        /// </summary>
        public DateTime? RozliczonyData { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Uwagi
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Flaga eROD (0/1)
        /// </summary>
        public int? Erod { get; set; }
        /// <summary>
        /// Flaga, czy rozliczenie z nadawcą za pomocą kwitu
        /// </summary>
        public int? RozlNadKwit { get; set; }
        /// <summary>
        /// Flaga, czy rozliczenie z nadawcą za adnotacji na LP
        /// </summary>
        public int? RozlNadLp { get; set; }
        /// <summary>
        /// Flaga, czy wezwanie
        /// </summary>
        public int? Wezwanie { get; set; }
        /// <summary>
        /// Data I wezwania
        /// </summary>
        public DateTime? Wezwanie1D { get; set; }
        /// <summary>
        /// Data II wezwania
        /// </summary>
        public DateTime? Wezwanie2D { get; set; }
        /// <summary>
        /// Data III wezwania
        /// </summary>
        public DateTime? Wezwanie3D { get; set; }
    }
}
