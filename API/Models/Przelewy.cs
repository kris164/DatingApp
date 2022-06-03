using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Przelewy
    {
        public int IdPrzelewy { get; set; }
        public string Nr { get; set; }
        public int? NrKolejny { get; set; }
        public int? NrRok { get; set; }
        public int? NrMies { get; set; }
        public DateTime? Data { get; set; }
        public int? TypPrzelewu { get; set; }
        public int? NadawcaId { get; set; }
        public string NadawcaNazwa { get; set; }
        public string NadawcaAdres { get; set; }
        public string NadawcaKod { get; set; }
        public string NadawcaMiasto { get; set; }
        public string NadawcaRachunek { get; set; }
        public int? PrzelewyRachunkiId { get; set; }
        public int? OdbiorcaId { get; set; }
        public string OdbiorcaNazwa { get; set; }
        public string OdbiorcaAdres { get; set; }
        public string OdbiorcaKod { get; set; }
        public string OdbiorcaMiasto { get; set; }
        public string OdbiorcaRachunek { get; set; }
        public string Tytul1 { get; set; }
        public string Tytul2 { get; set; }
        public string Tytul3 { get; set; }
        public string Tytul4 { get; set; }
        public double? Kwota { get; set; }
        public string Waluta { get; set; }
        public string ZusPlatnik1 { get; set; }
        public string ZusPlatnik2 { get; set; }
        public string ZusNip { get; set; }
        public string ZusTypDodId { get; set; }
        public string ZusDodId { get; set; }
        public string ZusTypWpl { get; set; }
        public string ZusOkr { get; set; }
        public string ZusNrDekl { get; set; }
        public string ZusNrDec { get; set; }
        public string UsPlatnik1 { get; set; }
        public string UsPlatnik2 { get; set; }
        public string UsTypId { get; set; }
        public string UsId { get; set; }
        public string UsFormularz { get; set; }
        public string UsRok { get; set; }
        public string UsTypOkr { get; set; }
        public string UsOkr { get; set; }
        public string UsIdZob { get; set; }
        public string OstPlik { get; set; }
        public DateTime? OstPlikData { get; set; }
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
        public int? Zagr { get; set; }
        public string NadawcaRachunekWal { get; set; }
        public string OdbiorcaRachunekWal { get; set; }
        public string ZagrSwift { get; set; }
        public string ZagrOplaty { get; set; }
        public string ZagrOplatyRach { get; set; }
        public double? ZagrKursNeg { get; set; }
        public DateTime? ZagrKursData { get; set; }
        public int? Sepa { get; set; }
        public int? OdbiorcaRachunekNieNrb { get; set; }
        public int? GenSesjaId { get; set; }
        public DateTime? DataKontrWykazWl { get; set; }
        public int? WynikKontrWykazWl { get; set; }
        public string RequestId { get; set; }
    }
}
