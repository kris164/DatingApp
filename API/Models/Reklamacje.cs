using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Reklamacje
    {
        public int IdReklamacje { get; set; }
        public int? AktywnaZakladka { get; set; }
        public string ReklSchemat { get; set; }
        public int? ReklSchematId { get; set; }
        public int? Niezgodnosc { get; set; }
        public DateTime? DataNiezg { get; set; }
        public string NrNiezg { get; set; }
        public int? NrNiezgKolejny { get; set; }
        public int? NrNiezgRok { get; set; }
        public int? NrNiezgMies { get; set; }
        public int? Reklamacja { get; set; }
        public DateTime? DataRekl { get; set; }
        public string NrRekl { get; set; }
        public int? NrReklKolejny { get; set; }
        public int? NrReklRok { get; set; }
        public int? NrReklMies { get; set; }
        public int? KtoZglasza { get; set; }
        public string Typ { get; set; }
        public string Stan { get; set; }
        public string Status { get; set; }
        public int? ObiektTyp { get; set; }
        public int? ObiektId { get; set; }
        public string ObiektNr { get; set; }
        public string Vin { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int? ListyLinioweId { get; set; }
        public string ListyLiniowe { get; set; }
        public int? PracownikId { get; set; }
        public string Pracownik { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string KlientTel { get; set; }
        public string KlientPracownik { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public string PrzewoznikTel { get; set; }
        public string PrzewoznikPracownik { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public string SamochodNrB { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string NaczepaNrB { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string KierowcaTel { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2 { get; set; }
        public string Kierowca2Tel { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public int? DokumZdj { get; set; }
        public int? DokumZdjIlosc { get; set; }
        public string DokumZdjOpis { get; set; }
        public int? Zalaczniki { get; set; }
        public string Opis { get; set; }
        public string Uwagi { get; set; }
        public string Wnioski { get; set; }
        public int? KtoWinny { get; set; }
        public int? KlientWinnyId { get; set; }
        public string KlientWinny { get; set; }
        public double? KwotaRoszczenia { get; set; }
        public string KwotaRoszczeniaWal { get; set; }
        public int? TworzSzkode { get; set; }
        public int? SzkodyId { get; set; }
        public string Szkody { get; set; }
        public DateTime? DataZdarzenia { get; set; }
        public DateTime? GodzZdarzenia { get; set; }
        public int? ReklZasadna { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
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
        public string FakturyTyp { get; set; }
        public int? FakturyId { get; set; }
        public string Faktury { get; set; }
        public DateTime? DataZakOcz { get; set; }
        public DateTime? DataZakRekl { get; set; }
        public string KtoWinnyNazwa { get; set; }
        public string SzkodyMiejsce { get; set; }
        public string LokalizacjaOdp { get; set; }
        public int? PaczkaId { get; set; }
        public string PaczkaNr { get; set; }
        public string OpisTowaru { get; set; }
        public DateTime? DataDecyzji { get; set; }
        public int? OdwolanieId { get; set; }
        public int? OdwolywanaId { get; set; }
        /// <summary>
        /// Nr odwołania. Pierwotna reklamacja ma 0
        /// </summary>
        public int NrOdwolaniaKolejny { get; set; }
        public string KlientNip { get; set; }
        public string KlientNazwa { get; set; }
        public int? PolisyId { get; set; }
        public string Polisy { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public double? KwotaNaPrzewoznika { get; set; }
        public double? KwotaNaPrzewoznikaWal { get; set; }
        public string JakWeszlo { get; set; }
        public string NrZewn { get; set; }
        public string SysZewnRef { get; set; }
        public int? JestCargo { get; set; }
        public string MailKontakt { get; set; }
    }
}
