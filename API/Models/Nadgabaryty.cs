using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Nadgabaryty
    {
        public int IdNadgabaryty { get; set; }
        public DateTime? Data { get; set; }
        public string NrWniosku { get; set; }
        public int? NrWnioskuKolejny { get; set; }
        public int? NrWnioskuRok { get; set; }
        public int? NrWnioskuMies { get; set; }
        public int? OsobaOdpowiedzialnaId { get; set; }
        public string OsobaOdpowiedzialna { get; set; }
        public int? OsobaWypelniajacaId { get; set; }
        public string OsobaWypelniajaca { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public string ZlecenieTyp { get; set; }
        public string Zleceniodawca { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientMiasto { get; set; }
        public string KlientKod { get; set; }
        public string KlientKraj { get; set; }
        public string KlientNip { get; set; }
        public string KlientTel { get; set; }
        public string KlientKont { get; set; }
        public short? InnyPrzewoznik { get; set; }
        public short? DoPrzedluzenia { get; set; }
        public short? Zakonczono { get; set; }
        public int? PrzewoznikId { get; set; }
        public string PrzewoznikSymbol { get; set; }
        public string PrzewoznikNazwa { get; set; }
        public string PrzewoznikAdres { get; set; }
        public string PrzewoznikMiasto { get; set; }
        public string PrzewoznikKod { get; set; }
        public string PrzewoznikKraj { get; set; }
        public string PrzewoznikNip { get; set; }
        public string PrzewoznikRegon { get; set; }
        public string PrzewoznikTel { get; set; }
        public string PrzewoznikKont { get; set; }
        public int? ZaMiejsceId { get; set; }
        public string ZaNazwa { get; set; }
        public string ZaAdres { get; set; }
        public string ZaKod { get; set; }
        public string ZaMiasto { get; set; }
        public string ZaKraj { get; set; }
        public int? WyMiejsceId { get; set; }
        public string WyNazwa { get; set; }
        public string WyAdres { get; set; }
        public string WyKod { get; set; }
        public string WyMiasto { get; set; }
        public string WyKraj { get; set; }
        public string LadunekOpis { get; set; }
        public double? LadunekMasa { get; set; }
        public short? PrzejazdWKolumnie { get; set; }
        public DateTime? PrzejazdDataOd { get; set; }
        public DateTime? PrzejazdDataDo { get; set; }
        public short? PrzejazdJednokrotny { get; set; }
        public int? IloscPrzejazdow { get; set; }
        public int? IloscPojazdow { get; set; }
        public int? CTaborId { get; set; }
        public string CNrRej { get; set; }
        public int? CLOsi { get; set; }
        public int? NTaborId { get; set; }
        public string NNrRej { get; set; }
        public int? NLOsi { get; set; }
        public double? DlugBezLadunku { get; set; }
        public double? SzerBezLadunku { get; set; }
        public double? WysBezLadunku { get; set; }
        public double? MasaBezLadunku { get; set; }
        public double? DlugZLadunkiem { get; set; }
        public double? SzerZLadunkiem { get; set; }
        public double? WysZLadunkiem { get; set; }
        public double? MasaZLadunkiem { get; set; }
        public double? ZwisLadunku { get; set; }
        public double? ZwisLadunkuPrzod { get; set; }
        public double? NaciskNaOs1 { get; set; }
        public double? NaciskNaOs2 { get; set; }
        public double? NaciskNaOs3 { get; set; }
        public double? NaciskNaOs4 { get; set; }
        public double? NaciskNaOs5 { get; set; }
        public double? NaciskNaOs6 { get; set; }
        public double? NaciskNaOs7 { get; set; }
        public double? NaciskNaOs8 { get; set; }
        public double? NaciskNaOs9 { get; set; }
        public double? NaciskNaOs10 { get; set; }
        public double? NaciskNaOs11 { get; set; }
        public double? NaciskNaOs12 { get; set; }
        public string ZezwolenieNr { get; set; }
        public DateTime? ZezwolenieDataWyd { get; set; }
        public DateTime? ZezwolenieDataObow { get; set; }
        public double? ZezwolenieKoszty { get; set; }
        public short? ZawieszeniePneumat { get; set; }
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
        public double? NaciskBezLadunkuNaOs1 { get; set; }
        public double? NaciskBezLadunkuNaOs2 { get; set; }
        public double? NaciskBezLadunkuNaOs3 { get; set; }
        public double? NaciskBezLadunkuNaOs4 { get; set; }
        public double? NaciskBezLadunkuNaOs5 { get; set; }
        public double? NaciskBezLadunkuNaOs6 { get; set; }
        public double? NaciskBezLadunkuNaOs7 { get; set; }
        public double? NaciskBezLadunkuNaOs8 { get; set; }
        public double? NaciskBezLadunkuNaOs9 { get; set; }
        public double? NaciskBezLadunkuNaOs10 { get; set; }
        public double? NaciskBezLadunkuNaOs11 { get; set; }
        public double? NaciskBezLadunkuNaOs12 { get; set; }
        public int? WnioskujacyId { get; set; }
        public string WnioskujacySymbol { get; set; }
        public string WnioskujacyNazwa { get; set; }
        public string WnioskujacyAdres { get; set; }
        public string WnioskujacyMiasto { get; set; }
        public string WnioskujacyKod { get; set; }
        public string WnioskujacyKraj { get; set; }
        public string WnioskujacyNip { get; set; }
        public string WnioskujacyRegon { get; set; }
        public string WnioskujacyTel { get; set; }
        public string WnioskujacyKont { get; set; }
        public string KategoriaWniosku { get; set; }
    }
}
