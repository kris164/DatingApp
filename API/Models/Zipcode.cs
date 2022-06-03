using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik kodów pocztowych
    /// </summary>
    public partial class Zipcode
    {
        public int IdZipcode { get; set; }
        /// <summary>
        /// Kod kraju
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Kod pocztowy
        /// </summary>
        public string ZipCode1 { get; set; }
        /// <summary>
        /// Miasto
        /// </summary>
        public string Town { get; set; }
        /// <summary>
        /// Ulica
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Powiat
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// Województwo
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// Poczta
        /// </summary>
        public string PostOffice { get; set; }
        /// <summary>
        /// ?
        /// </summary>
        public string PoBoxZip { get; set; }
        /// <summary>
        /// ?
        /// </summary>
        public string OwnZipUnit { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? GeoLongi { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? GeoLat { get; set; }
        /// <summary>
        /// ?
        /// </summary>
        public int? Route { get; set; }
        /// <summary>
        /// ?
        /// </summary>
        public int? IdCenter { get; set; }
        /// <summary>
        /// ?
        /// </summary>
        public string Zone { get; set; }
        /// <summary>
        /// Strefa
        /// </summary>
        public string Strefa { get; set; }
        /// <summary>
        /// Kod pocztowy bez znaków separujących
        /// </summary>
        public string Zip { get; set; }
        /// <summary>
        /// Numer aktualizacji
        /// </summary>
        public int? Aktual { get; set; }
        /// <summary>
        /// Flaga, czy kod został zgeokodowany
        /// </summary>
        public int? Gps { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Kod zablokowany do automatyczego zmieniania stref
        /// </summary>
        public int? Blokada { get; set; }
        /// <summary>
        /// Lokalizacja tymczasowa
        /// </summary>
        public string TmpLokalizacja { get; set; }
        /// <summary>
        /// Strefa tymczasowa
        /// </summary>
        public string TmpStrefa { get; set; }
        /// <summary>
        /// Wyliczona odległość od lokalizacji tymczasowej
        /// </summary>
        public double? TmpRoute { get; set; }
        /// <summary>
        /// Podstrefa
        /// </summary>
        public string Podstrefa { get; set; }
        /// <summary>
        /// Lokalizacja 2
        /// </summary>
        public string Lokalizacja2 { get; set; }
        /// <summary>
        /// Gmina
        /// </summary>
        public string Gmina { get; set; }
        /// <summary>
        /// ulica bez numeru
        /// </summary>
        public string ZipStreet { get; set; }
        /// <summary>
        /// numer
        /// </summary>
        public string ZipNumber { get; set; }
        public int? ProvinceId { get; set; }
        /// <summary>
        /// GPS - akceptacja
        /// </summary>
        public int? GeoAkceptacja { get; set; }
        /// <summary>
        /// GPS - poziom ufności
        /// </summary>
        public int? GeoPoziomUfn { get; set; }
        public int? MapGeoCoding { get; set; }
    }
}
