using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Szkody
    {
        public int IdSzkody { get; set; }
        public int? PolisaId { get; set; }
        public string Polisa { get; set; }
        public string TypSzkody { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? WinaKierowcy { get; set; }
        public string Rodzaj { get; set; }
        public string NumerSzkody { get; set; }
        public DateTime? DataZdarzenia { get; set; }
        public DateTime? GodzZdarzenia { get; set; }
        public string Uwagi { get; set; }
        public double? KwotaKalkulacji { get; set; }
        public double? KwotaKosztow { get; set; }
        public int? Zalaczniki { get; set; }
        public DateTime? MaxDataZglosz { get; set; }
        public int? Zgloszona { get; set; }
        public string Status { get; set; }
        public int? UbezpieczycielId { get; set; }
        public string Ubezpieczyciel { get; set; }
        public string NrSzkody { get; set; }
        public int? NrSzkodyKolejny { get; set; }
        public int? NrSzkodyRok { get; set; }
        public int? NrSzkodyMies { get; set; }
        public string SprawcaImieNazwisko { get; set; }
        public string SprawcaAdres { get; set; }
        public string SprawcaMiasto { get; set; }
        public string SprawcaKraj { get; set; }
        public string SprawcaPojazd { get; set; }
        public string SprawcaPesel { get; set; }
        public string SprawcaNrPrawaJ { get; set; }
        public string SprawcaNrPolisy { get; set; }
        public string SprawcaUbezp { get; set; }
        public string SprawcaTel { get; set; }
        public int? Ocp { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string Lokalizacja { get; set; }
        public string TaborNrBoczny { get; set; }
        public DateTime? Data { get; set; }
        public string Uwagi2 { get; set; }
        public DateTime? DataZgloszenia { get; set; }
        public DateTime? DataDzialTechniczny { get; set; }
        public string StatusKod { get; set; }
        public string StatusUwagi { get; set; }
        public int? Samolikwidacja { get; set; }
        public double? KosztyWylaczenia { get; set; }
        public double? KosztyInne { get; set; }
        public int? SzkodaTransportowa { get; set; }
        public string Vin { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KwotaKalkulacjiWal { get; set; }
        public string KwotaKosztowWal { get; set; }
        public string KosztyWylaczeniaWal { get; set; }
        public string KosztyInneWal { get; set; }
        public string SposobLikw { get; set; }
        public string SposobLikwPolisa { get; set; }
        public string SposobLikwUbezp { get; set; }
        public string Uwagi3 { get; set; }
        public int? Policja { get; set; }
        public string StatusEmisja { get; set; }
        public string SprawcaKod { get; set; }
        public string PoszkodowanyImieNazwisko { get; set; }
        public string PoszkodowanyAdres { get; set; }
        public string PoszkodowanyMiasto { get; set; }
        public string PoszkodowanyKod { get; set; }
        public string PoszkodowanyKraj { get; set; }
        public string PoszkodowanyPojazd { get; set; }
        public string PoszkodowanyPesel { get; set; }
        public string PoszkodowanyTel { get; set; }
    }
}
