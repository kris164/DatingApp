using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaC
    {
        public int IdZleceniaC { get; set; }
        public DateTime? DataRejestracji { get; set; }
        public string NrZlecenia { get; set; }
        public int? NrZleceniaKolejny { get; set; }
        public int? NrZleceniaRok { get; set; }
        public int? NrZleceniaMies { get; set; }
        public string Status { get; set; }
        public int? Typ { get; set; }
        public int? Rodzaj { get; set; }
        public int? Procedura { get; set; }
        public int? KlientId { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientNazwa { get; set; }
        public string KlientAdres { get; set; }
        public string KlientMiasto { get; set; }
        public string KlientKod { get; set; }
        public string KlientKraj { get; set; }
        public string KlientNip { get; set; }
        public string KlientFax { get; set; }
        public string KlientKont { get; set; }
        public string KlientTel { get; set; }
        public int? PlatnikId { get; set; }
        public string PlatnikSymbol { get; set; }
        public string PlatnikNazwa { get; set; }
        public string PlatnikAdres { get; set; }
        public string PlatnikMiasto { get; set; }
        public string PlatnikKod { get; set; }
        public string PlatnikKraj { get; set; }
        public string PlatnikNip { get; set; }
        public int? Zafakturowane { get; set; }
        public int? FvNaPlatnika { get; set; }
        public int? OdroczonyVat { get; set; }
        public int? RejestrujacyId { get; set; }
        public string Rejestrujacy { get; set; }
        public int? AgentCelnyId { get; set; }
        public string AgentCelny { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public DateTime? DataZwolnienia { get; set; }
        public DateTime? DataZakonczenia { get; set; }
        public DateTime? PrzewDataZakonczenia { get; set; }
        public string NumerZewn { get; set; }
        public string Cn { get; set; }
        public string Mrn { get; set; }
        public string NrZgloszenia { get; set; }
        public DateTime? DataZgloszenia { get; set; }
        public int? Zalaczniki { get; set; }
        public int? UpowaznienieId { get; set; }
        public string UpowaznienieNr { get; set; }
        public string UpowaznienieInny { get; set; }
        public int? Zabezpieczenie { get; set; }
        public int? ZabezpieczenieId { get; set; }
        public string ZabezpieczenieNr { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string Opis { get; set; }
        public string Uwagi { get; set; }
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
        public int? Anulowane { get; set; }
        public string NrFaktury { get; set; }
        public string KodTowaru { get; set; }
        public string OpisTowaru { get; set; }
        public double? WartoscStatystyczna { get; set; }
        public double? WartoscTowaru { get; set; }
        public string Waluta { get; set; }
        public double? KursWaluty { get; set; }
        public string KrajZaladunku { get; set; }
        public string KrajRozladunku { get; set; }
        public string KrajPoczatkowy { get; set; }
        public string KrajKoncowy { get; set; }
        public DateTime? DataPrzyjecia { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public DateTime? DataPrzelewu { get; set; }
        public int? ImpekspId { get; set; }
        public string ImpekspSymbol { get; set; }
        public string ImpekspNazwa { get; set; }
        public string ImpekspAdres { get; set; }
        public string ImpekspMiasto { get; set; }
        public string ImpekspKod { get; set; }
        public string ImpekspKraj { get; set; }
        public string ImpekspNip { get; set; }
        public int? UpowaznienieInne { get; set; }
        public int? PrzelewyCelneId { get; set; }
        public string PrzelewyCelneNr { get; set; }
        public int? RozliczonyVat { get; set; }
        public string UrzadCelny { get; set; }
        public string NrDecyzji { get; set; }
        public int? ZlecenieUzup { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
        public double? MasaBrutto { get; set; }
        public double? MasaNetto { get; set; }
        public string CennikSqlPrzychody { get; set; }
        public string CennikSqlKoszty { get; set; }
    }
}
