using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WZlecenium
    {
        public int IdWZlecenia { get; set; }
        public string Status { get; set; }
        public string RodzajZlecenia { get; set; }
        public string NrDok { get; set; }
        public int? NrDokKolejny { get; set; }
        public int? NrDokRok { get; set; }
        public int? NrDokMies { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public DateTime? DataZakonczenia { get; set; }
        public DateTime? DataZgloszenia { get; set; }
        public int? StanLicznika { get; set; }
        public int? WlasnyPojazd { get; set; }
        public int? KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public int? PojazdId { get; set; }
        public string Pojazd { get; set; }
        public string NrNadwozia { get; set; }
        public string NrSilnika { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Wersja { get; set; }
        public string FormaPlatnosci { get; set; }
        public int? TerminPlatnosci { get; set; }
        public DateTime? DataZaplaty { get; set; }
        public int? StawkiId { get; set; }
        public string Stawki { get; set; }
        public int? Naprawa { get; set; }
        public string NaprawaOpis { get; set; }
        public double? NaprawaPKoszt { get; set; }
        public int? BadanieTechniczne { get; set; }
        public string BadanieTechniczneOpis { get; set; }
        public double? BadaniePKoszt { get; set; }
        public int? Przeglad { get; set; }
        public double? PrzegladPo { get; set; }
        public string PrzegladOpis { get; set; }
        public double? PrzegladPKoszt { get; set; }
        public string InneParam { get; set; }
        public string Uwagi { get; set; }
        public int? ZlecajacyId { get; set; }
        public string Zlecajacy { get; set; }
        public int? PrzyjmujacyId { get; set; }
        public string Przyjmujacy { get; set; }
        public DateTime? TerminOdbioru { get; set; }
        public DateTime? TerminOdbioruGodz { get; set; }
        public double? LacznyPKoszt { get; set; }
        public int? NadzorcaId { get; set; }
        public string Nadzorca { get; set; }
        public int? WStanowiskaId { get; set; }
        public string WStanowiska { get; set; }
        public string InstrDlaSerwisu { get; set; }
        public string PrzyczynyZalecenia { get; set; }
        public string ZauwazoneUsterki { get; set; }
        public double? NajblPrzegladPoKm { get; set; }
        public DateTime? NajblPrzegladData { get; set; }
        public string Faktura { get; set; }
        public int? FakturaId { get; set; }
        public string WFaktura { get; set; }
        public int? WFakturaId { get; set; }
        public int? ZaksiegowanoSpeed { get; set; }
        public string Zdawczy { get; set; }
        public string Odbiorczy { get; set; }
        public int? StatusPilne { get; set; }
        public DateTime? DataPlanowana { get; set; }
        public int? StanPaliwa { get; set; }
        public int? IleKmDoPrzegladu { get; set; }
        public string PojazdNrBoczny { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? ZlecenieZewn { get; set; }
        public int? ZleceniobiorcaId { get; set; }
        public string ZleceniobiorcaSymbol { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? Mycie { get; set; }
        public string MycieOpis { get; set; }
        public double? MyciePKoszt { get; set; }
        public string WFakturaK { get; set; }
        public int? WFakturaKId { get; set; }
        public string WParagon { get; set; }
        public int? WParagonId { get; set; }
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
        public int? Reklamacja { get; set; }
        public int? ReklamacjaDoId { get; set; }
        public string ReklamacjaDo { get; set; }
        public string InneUwagi { get; set; }
        public int? SaMagObcy { get; set; }
        public int? SaRez { get; set; }
        public DateTime? GodzZakonczenia { get; set; }
        public DateTime? GodzZgloszenia { get; set; }
        public DateTime? GodzPlanowana { get; set; }
        public string NrZlecKl { get; set; }
        public string MycieOstLad { get; set; }
        public int? MycieNaczepaId { get; set; }
        public string MycieNaczepa { get; set; }
        public int? MycieKomora1 { get; set; }
        public int? MycieKomora2 { get; set; }
        public int? MycieKomora3 { get; set; }
        public int? MycieKomora4 { get; set; }
        public int? MycieKomora5 { get; set; }
        public string WalutaFv { get; set; }
        public int? SzkodyId { get; set; }
        public string Szkody { get; set; }
        public int? ParagonFiskalny { get; set; }
        public int? StatusWykonawczy { get; set; }
        public string StatusWykonawczyKod { get; set; }
        public string StatusWykonawczyOpis { get; set; }
        public int? TypPracownika { get; set; }
        public string WZleceniaOfertyNumer { get; set; }
        public int? WZleceniaOfertyId { get; set; }
        /// <summary>
        /// Numer telefonu do siedziby klienta 1
        /// </summary>
        public string Telefon1 { get; set; }
        /// <summary>
        /// Numer telefonu do siedziby klienta 2
        /// </summary>
        public string Telefon2 { get; set; }
        /// <summary>
        /// Główny adres email
        /// </summary>
        public string Email { get; set; }
        public string KierowcaTelSluzbowy { get; set; }
    }
}
