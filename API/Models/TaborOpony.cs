using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Opony
    /// </summary>
    public partial class TaborOpony
    {
        public int IdTaborOpony { get; set; }
        /// <summary>
        /// Numer seryjny opony
        /// </summary>
        public string NrSeryjny { get; set; }
        /// <summary>
        /// Numer fabryczny opony
        /// </summary>
        public string NrFabryczny { get; set; }
        /// <summary>
        /// Rodzaj opony
        /// </summary>
        public string Rodzaj { get; set; }
        /// <summary>
        /// Rozmiar opony
        /// </summary>
        public string Rozmiar { get; set; }
        /// <summary>
        /// Marka opony
        /// </summary>
        public string Marka { get; set; }
        /// <summary>
        /// Rodzaj bieżnika
        /// </summary>
        public string Bieznik { get; set; }
        /// <summary>
        /// Parametry dodatkowe - mapa bitowa
        /// </summary>
        public string ParamDod { get; set; }
        /// <summary>
        /// Dowolne uwagi dodatkowe
        /// </summary>
        public string UwagiDod { get; set; }
        /// <summary>
        /// Norma przebiegu dla opony
        /// </summary>
        public int? NormaPrzebiegu { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - typ
        /// </summary>
        public string OstTypObsl { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - nr rejstracyjny pojazdu
        /// </summary>
        public string OstTabor { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? OstTaborId { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - numer osi pojazdu
        /// </summary>
        public int? OstNrOsi { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - strona montażu
        /// </summary>
        public string OstStrona { get; set; }
        /// <summary>
        /// Data założenia opony
        /// </summary>
        public DateTime? DataZalozenia { get; set; }
        /// <summary>
        /// Data zużycia opony
        /// </summary>
        public DateTime? DataZuzycia { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - ciśnienie
        /// </summary>
        public double? OstCisnienie { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - wysokość bieżnika
        /// </summary>
        public double? OstWysBiezn { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - data
        /// </summary>
        public DateTime? OstData { get; set; }
        /// <summary>
        /// Magazyn
        /// </summary>
        public string Magazyn { get; set; }
        /// <summary>
        /// Relacja do tabeli towarów w warsztacie - tab: W_MAG_TOWARY
        /// </summary>
        public int? WMagTowaryId { get; set; }
        /// <summary>
        /// Relacja do nagłówka PZ w warsztacie - tab: W_MAG_PRZYJECIA
        /// </summary>
        public int? WMagPrzyjeciaId { get; set; }
        /// <summary>
        /// Relacja do pozycji PZ w warsztacie - tab: W_MAG_PRZYJECIA_POZ
        /// </summary>
        public int? WMagPrzyjeciaPozId { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Ilość załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
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
        /// <summary>
        /// Ostatnie zdarzenie - nr boczny pojazdu
        /// </summary>
        public string OstTaborNrB { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - licznik pojazdu
        /// </summary>
        public double? OstLicznik { get; set; }
        /// <summary>
        /// Przebieg opony na podstawie PW
        /// </summary>
        public int? PrzebiegPw { get; set; }
        /// <summary>
        /// Przebieg, po jakim powinna nastąpić kontrola
        /// </summary>
        public int? KontrolaCo { get; set; }
        /// <summary>
        /// Przebieg następnej kontroli
        /// </summary>
        public int? KontrolaNast { get; set; }
        /// <summary>
        /// Przebieg opony BO
        /// </summary>
        public int? PrzebiegBo { get; set; }
        /// <summary>
        /// Przypisanie do pojazdu
        /// </summary>
        public string PrzypDoTabor { get; set; }
        /// <summary>
        /// Przypisanie do pojazdu - tab: TABOR
        /// </summary>
        public int? PrzypDoTaborId { get; set; }
        /// <summary>
        /// Relacja do opony pierwotnej - tab: TABOR_OPONY
        /// </summary>
        public int? TaborOponyId { get; set; }
        /// <summary>
        /// Flaga, czy opona aktywna
        /// </summary>
        public int? Aktywna { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - reklamacja
        /// </summary>
        public int? OstReklamacja { get; set; }
        /// <summary>
        /// Powód zużycia
        /// </summary>
        public string PowodZuzycia { get; set; }
        /// <summary>
        /// Flaga, do bieżnikowania
        /// </summary>
        public int? DoBieznikowania { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - wysokość bieżnika 2
        /// </summary>
        public double? OstWysBiezn2 { get; set; }
        /// <summary>
        /// Ostatnie zdarzenie - wysokość bieżnika 3
        /// </summary>
        public double? OstWysBiezn3 { get; set; }
    }
}
