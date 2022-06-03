using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKalkulacje
    {
        public int IdTmpKalkulacje { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? Lp { get; set; }
        public string OpisKod { get; set; }
        public int? OpisId { get; set; }
        public string Opis { get; set; }
        public string OpisDod { get; set; }
        public int? CennikId { get; set; }
        public string Cennik { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string Waluta { get; set; }
        public double? NettoK { get; set; }
        public string VatId { get; set; }
        public double? StawkaVat { get; set; }
        public int? Cod { get; set; }
        public int? Ubezp { get; set; }
        public int? Sms { get; set; }
        public int? Oplata { get; set; }
        public int? Transport { get; set; }
        public int? Rm { get; set; }
        public int? Ro { get; set; }
        public string Typ { get; set; }
        public double? Ilosc { get; set; }
        public double? CenaJedn { get; set; }
        public int? IdKalkulacje { get; set; }
        public string WalutaFv { get; set; }
        /// <summary>
        /// FV/NO/RW
        /// </summary>
        public string JakRozl { get; set; }
        public DateTime? WprowCzas { get; set; }
        public string WprowKto { get; set; }
        public string WprowLok { get; set; }
        public string WprowDzial { get; set; }
        public string Dotyczy { get; set; }
        public double? Rabat { get; set; }
        public double? RabatWartosc { get; set; }
        public int? Akcept { get; set; }
        public int? Visible { get; set; }
        public int? Dontsave { get; set; }
        public string KursWgDaty { get; set; }
        public int? TypTab { get; set; }
        public string TypKurs { get; set; }
        public string Jm { get; set; }
        /// <summary>
        /// Typ kontenera
        /// </summary>
        public string KonteneryTyp { get; set; }
        public string CennikInfo { get; set; }
        public int? PaczkiId { get; set; }
        /// <summary>
        /// Flaga, czy pozycja pochodzi z RKTNP (Rozliczenie Kosztów Trasy Na Przesyłki)
        /// </summary>
        public int? Rktnp { get; set; }
        /// <summary>
        /// Relacja do kalulacji na trasie (używane w RKTNP)
        /// </summary>
        public int? RktnpKalkTrasyId { get; set; }
        /// <summary>
        /// Relacja do pozycji faktury (używane w RKTNP)
        /// </summary>
        public int? RktnpFvPozId { get; set; }
        /// <summary>
        /// Relacja do RW (używane w RKTNP)
        /// </summary>
        public int? RktnpRwId { get; set; }
        public int? ObiektId { get; set; }
        public string Kategoria { get; set; }
        public double? KursWym { get; set; }
        public int? KonteneryId { get; set; }
        public string Kontenery { get; set; }
        public double? MarzaWart { get; set; }
        public int? MarzaTyp { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public double? NettoF { get; set; }
        public string WalutaF { get; set; }
        public int? DoRozliczenia { get; set; }
        public int? TylkoRelacja { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? PromyId { get; set; }
        public int? GotDoFv { get; set; }
        public DateTime? AkceptCzas { get; set; }
        public string AkceptKto { get; set; }
        public string AkceptLok { get; set; }
        public string AkceptDzial { get; set; }
        public string AkceptUwagi { get; set; }
        public short? KorDoZera { get; set; }
        /// <summary>
        /// Relacja do identyfikacji promu (używane w RKTNP)
        /// </summary>
        public int? RktnpPromyId { get; set; }
        /// <summary>
        /// Kody typów opłat stosowane w polu 47 formularza SAD
        /// </summary>
        public string TypOplaty { get; set; }
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
