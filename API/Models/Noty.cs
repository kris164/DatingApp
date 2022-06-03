using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Noty
    {
        public int IdNoty { get; set; }
        public string Rodzaj { get; set; }
        public int? KorektaId { get; set; }
        public int? Korekta { get; set; }
        public string KontrahTyp { get; set; }
        public int? KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public int? NotaOtrzymana { get; set; }
        public int? NotaObciazeniowa { get; set; }
        public string Numer { get; set; }
        public DateTime? Data { get; set; }
        public string Tresc { get; set; }
        public double? Kwota { get; set; }
        public string Typ { get; set; }
        public int? Zaplacono { get; set; }
        public int? Zaksiegowana { get; set; }
        public DateTime? DataZaksiegowania { get; set; }
        public DateTime? DataSplaty { get; set; }
        public string TrescDopisek { get; set; }
        public int? NumerN { get; set; }
        public int? RokN { get; set; }
        public int? MiesN { get; set; }
        public DateTime? TerminZaplaty { get; set; }
        public string Lokalizacja { get; set; }
        public string JezykWydruku { get; set; }
        public int? KontoId { get; set; }
        public string Konto { get; set; }
        public int? Iban { get; set; }
        public string WydrukSporzadzil { get; set; }
        public int? LOrg { get; set; }
        public int? LKop { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public int? KursyWalutId { get; set; }
        public int? KursyWalutTyp { get; set; }
        public string KursyWalutRodz { get; set; }
        public int? NotaWalutowa { get; set; }
        public double? KursWaluty { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public string Waluta { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public string ZlecenieTyp { get; set; }
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
        public double? KwotaKor { get; set; }
        public int? StatusZaplaty { get; set; }
        public string InfoOpiekuna { get; set; }
        public DateTime? DataSprzedazy { get; set; }
        public DateTime? DataOtrzymania { get; set; }
        public string Dzial { get; set; }
        public DateTime? DataPotw { get; set; }
        public string Dekret { get; set; }
        public int? DekretKolejny { get; set; }
        public int? DekretRok { get; set; }
        public int? DekretMies { get; set; }
        public int? TrafikId { get; set; }
        public string Trafik { get; set; }
        public int? SaKontakty { get; set; }
        public int? KomunikacjaFkId { get; set; }
        public int? StatusWindykacji { get; set; }
        public string GrupaDok { get; set; }
        public int? WydrukDuplikat { get; set; }
        public int? WystawionoDuplikat { get; set; }
        public DateTime? DataDuplikatu { get; set; }
        public int? ReklamacjeId { get; set; }
        public string Reklamacje { get; set; }
        public string StatusWindKto { get; set; }
        public DateTime? StatusWindKiedy { get; set; }
        public int? OddzialId { get; set; }
        public string OddzialNazwa { get; set; }
        public string OddzialAdres { get; set; }
        public string OddzialMiasto { get; set; }
        public string OddzialKod { get; set; }
        public string OddzialKraj { get; set; }
        public string StatusNew { get; set; }
        public int? Anulowana { get; set; }
        public string FormaPlatnosci { get; set; }
        public int TerminPlatnosci { get; set; }
        public int? EmisjaDoFk { get; set; }
        public string NrSped { get; set; }
        public string KomunikacjaFkInfo { get; set; }
        public int? ZlecenieCId { get; set; }
        public string ZlecenieC { get; set; }
        public DateTime? DataPlatnosciUsr { get; set; }
        public int? TerminPlatnosciUsr { get; set; }
    }
}
