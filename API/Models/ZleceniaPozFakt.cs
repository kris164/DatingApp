using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaPozFakt
    {
        public int IdZleceniaPozFakt { get; set; }
        public int? ZlecenieId { get; set; }
        public int? FakturyPozycjeId { get; set; }
        public int? FakturyId { get; set; }
        public string Faktury { get; set; }
        public int? Lp { get; set; }
        public string RodzPrzychodow { get; set; }
        public int? TytulId { get; set; }
        public string Tytul { get; set; }
        public string TytulOpis { get; set; }
        public string Pkwiu { get; set; }
        public string Jm { get; set; }
        public double? Ilosc { get; set; }
        public double? NettoWartosc { get; set; }
        public string VatId { get; set; }
        public double? VatStawka { get; set; }
        public string Waluta { get; set; }
        public double? KursWaluty { get; set; }
        public int? KursyWalutId { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string Typ { get; set; }
        public string RodzKosztow { get; set; }
        public int? KontrahId { get; set; }
        public string Kontrah { get; set; }
        public double? CenaJedn { get; set; }
        public int? PromyId { get; set; }
        public short? KorDoZera { get; set; }
        public string WalutaFv { get; set; }
        public int? Rm { get; set; }
        public int? Ro { get; set; }
        public string TytulKod { get; set; }
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
        /// FV/NO/RW
        /// </summary>
        public string JakRozl { get; set; }
        public int? KonteneryId { get; set; }
        public string Kontenery { get; set; }
        public int? Rknz { get; set; }
        public double? RknzWartosc { get; set; }
        public double? RknzWartoscFv { get; set; }
        /// <summary>
        /// Relacja do kalulacji na ZB (używane w RKNZ)
        /// </summary>
        public int? RknzKalkTrasyId { get; set; }
        /// <summary>
        /// Relacja do pozycji faktury (używane w RKNZ)
        /// </summary>
        public int? RknzFvPozId { get; set; }
        /// <summary>
        /// Relacja do RW (używane w RKTNP)
        /// </summary>
        public int? RknzRwId { get; set; }
        public string WprowLok { get; set; }
        public string WprowDzial { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na poz. dod. zlecenie z którego powstała bieżąca pozycja
        /// </summary>
        public int? MaszonskiMasterZlecPozFaktId { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na poz. dod. koszt. zlecenie z którego powstała bieżąca pozycja
        /// </summary>
        public int? MaszonskiMasterZlecPozFaktKId { get; set; }
        public int? Ubezp { get; set; }
    }
}
