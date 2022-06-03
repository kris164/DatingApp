using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzablonyZlecen
    {
        public int IdSzablonyZlecen { get; set; }
        public string OznaczenieWzorca { get; set; }
        public string Typ { get; set; }
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
        public int? PlatnikId { get; set; }
        public string PlatnikSymbol { get; set; }
        public string PlatnikNazwa { get; set; }
        public string PlatnikAdres { get; set; }
        public string PlatnikMiasto { get; set; }
        public string PlatnikKod { get; set; }
        public string PlatnikKraj { get; set; }
        public string PlatnikNip { get; set; }
        public int? PrzewoznikId { get; set; }
        public string PrzewoznikSymbol { get; set; }
        public string PrzewoznikNazwa { get; set; }
        public string PrzewoznikAdres { get; set; }
        public string PrzewoznikMiasto { get; set; }
        public string PrzewoznikKod { get; set; }
        public string PrzewoznikKraj { get; set; }
        public string PrzewoznikNip { get; set; }
        public string PrzewoznikTel { get; set; }
        public string PrzewoznikKont { get; set; }
        public string WarunkiDostawy { get; set; }
        public string TypZlecenia { get; set; }
        public string OpisTowaru { get; set; }
        public string OpisWymagTaboru { get; set; }
        public int? OdprawaCelnaWywozId { get; set; }
        public string OdprawaCelnaWywoz { get; set; }
        public int? OdprawaCelnaWwozId { get; set; }
        public string OdprawaCelnaWwoz { get; set; }
        public int? OdprawaGranicznaId { get; set; }
        public string OdprawaGraniczna { get; set; }
        public int? TrasaId { get; set; }
        public string Trasa { get; set; }
        public double? TrasaOdl { get; set; }
        public string JednWagi { get; set; }
        public double? WagaLadunku { get; set; }
        public double? ObjetoscLadunku { get; set; }
        public double? Wysokosc { get; set; }
        public double? Szerokosc { get; set; }
        public double? Dlugosc { get; set; }
        public string TypOpakowania { get; set; }
        public double? IloscOpakowan { get; set; }
        public double? WartoscLadunku { get; set; }
        public string WartoscLadunkuWal { get; set; }
        public string DodOpakowania { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string InfoDod { get; set; }
        public string InfoDodKl { get; set; }
        public int? Kierowca1Id { get; set; }
        public string Kierowca1 { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2 { get; set; }
        public double? KwotaK { get; set; }
        public string WalutaK { get; set; }
        public string FormaPlatnosciK { get; set; }
        public int? TerminK { get; set; }
        public int? OdcKrajowyKmK { get; set; }
        public double? OdcKrajowyK { get; set; }
        public double? OdcKrajowyVatK { get; set; }
        public string OdcKrajowyVatIdK { get; set; }
        public int? OdcUeKmK { get; set; }
        public double? OdcUeK { get; set; }
        public double? OdcUeVatK { get; set; }
        public string OdcUeVatIdK { get; set; }
        public int? OdcZagranicznyKmK { get; set; }
        public double? OdcZagranicznyK { get; set; }
        public double? OdcZagranicznyVatK { get; set; }
        public string OdcZagranicznyVatIdK { get; set; }
        public double? KwotaP { get; set; }
        public string WalutaP { get; set; }
        public string FormaPlatnosciP { get; set; }
        public int? TerminP { get; set; }
        public int? OdcKrajowyKmP { get; set; }
        public double? OdcKrajowyP { get; set; }
        public double? OdcKrajowyVatP { get; set; }
        public string OdcKrajowyVatIdP { get; set; }
        public int? OdcUeKmP { get; set; }
        public double? OdcUeP { get; set; }
        public double? OdcUeVatP { get; set; }
        public string OdcUeVatIdP { get; set; }
        public int? OdcZagranicznyKmP { get; set; }
        public double? OdcZagranicznyP { get; set; }
        public double? OdcZagranicznyVatP { get; set; }
        public string OdcZagranicznyVatIdP { get; set; }
        public string Ustalenia { get; set; }
        public string UstaleniaPotw { get; set; }
        public string Lokalizacja { get; set; }
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
        public double? TempPrzewozu { get; set; }
        public string TempPrzewozuO { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public string Opiekun { get; set; }
        public int? TaborProfilId { get; set; }
        public string TaborProfil { get; set; }
        public DateTime? DataAktyw { get; set; }
        public DateTime? DataDeakt { get; set; }
        public int? Aktywny { get; set; }
        public int? FrmId { get; set; }
        public string JezykZlecenia { get; set; }
        public string RodzZlec { get; set; }
        public int? OddzialId { get; set; }
        public string OddzialNazwa { get; set; }
        public string OddzialAdres { get; set; }
        public string OddzialMiasto { get; set; }
        public string OddzialKod { get; set; }
        public string OddzialKraj { get; set; }
        public string ZaMiejsce { get; set; }
        public string ZaMiasto { get; set; }
        public string ZaKraj { get; set; }
        public string ZaKod { get; set; }
        public string WyMiejsce { get; set; }
        public string WyMiasto { get; set; }
        public string WyKraj { get; set; }
        public string WyKod { get; set; }
        public int? VatNaSadzie { get; set; }
        public string TrasaDojazdu { get; set; }
        public int? TrasaEdycja { get; set; }
        public string TrasaDolad { get; set; }
        public double? TrasaOdlDojazd { get; set; }
        public double? TrasaOdlGl { get; set; }
        public double? TrasaZlecOdl { get; set; }
        public double? TrasaZlecOdlDojazd { get; set; }
        public double? TrasaZlecOdlGl { get; set; }
        public double? TrasaOdlRozn { get; set; }
        public string OpisTowaruUn { get; set; }
        public string OpisTowaruHaccp { get; set; }
        public string OpisTowaruSqas { get; set; }
        public int? Adr { get; set; }
        public int? CysternaDoPelna { get; set; }
        public int? Prom { get; set; }
        public int? Myjnia { get; set; }
        public int? WymianaPalet { get; set; }
        public string DodJm { get; set; }
        public int? DodIl { get; set; }
        public int? KubaturaPojazdu { get; set; }
        public string SamochodNrBoczny { get; set; }
        public int? NaczepaKlienta { get; set; }
        public string NaczepaNrBoczny { get; set; }
        public string Kierowca1Tel { get; set; }
        public string Kierowca2Tel { get; set; }
        public int? CennikFtlId { get; set; }
        public string CennikFtl { get; set; }
        public int? CennikFtlPId { get; set; }
        public string CennikFtlP { get; set; }
        public string TypKursK { get; set; }
        public string TypKursP { get; set; }
        public string RefNad { get; set; }
        public string RefOdb { get; set; }
        public string RefPos { get; set; }
        public double? KwotaKUstalona { get; set; }
        public double? StawkaZaKm { get; set; }
        public double? StawkaZaWagaKm { get; set; }
        public double? KwotaPUstalona { get; set; }
        public double? StawkaZaKmP { get; set; }
        public double? StawkaZaWagaKmP { get; set; }
        public double? OrgFrachtP { get; set; }
        public double? DodFrachtWewn { get; set; }
        public double? LiczbaZawy { get; set; }
        public double? CenaZaMZawy { get; set; }
        public string CenaZaMZawyWal { get; set; }
        public string Dzial { get; set; }
        public string InfoDlaKsieg { get; set; }
        public double? WagaLadunkuRz { get; set; }
        /// <summary>
        /// Informacje dla SFM-a
        /// </summary>
        public string InfoSfm { get; set; }
        public int? TypTabK { get; set; }
        public int? TypTabP { get; set; }
        public string WalutaFvK { get; set; }
        public string WalutaFvP { get; set; }
        public double? TrasaMapOdl { get; set; }
        public double? TrasaMapOdlDojazd { get; set; }
        public double? TrasaMapOdlGl { get; set; }
        public int? Clenie { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public int? BezSfm { get; set; }
        public string KursWgK { get; set; }
        public int? KursZDniaPK { get; set; }
        public string KursWgP { get; set; }
        public int? KursZDniaPP { get; set; }
        public double? RozKierFracht { get; set; }
        public double? TrasaMapMyto { get; set; }
        public double? TrasaMapKmPlatne { get; set; }
        public int? DyspozytorId { get; set; }
        public string Dyspozytor { get; set; }
        public int? VatWPlnK { get; set; }
        public int? VatWPlnP { get; set; }
        public double? TrasaCcOdl { get; set; }
        public double? TrasaCcOdlDojazd { get; set; }
        public double? TrasaCcOdlGl { get; set; }
        public string PrzewoznikEmail { get; set; }
        public string TrybPracyAgregatu { get; set; }
    }
}
