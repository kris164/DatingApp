using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DostepnyTabor
    {
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdTaboru { get; set; }
        public int? IdNaczepy { get; set; }
        public int? ProfilId { get; set; }
        public double? MaxIlosc { get; set; }
        public double? MaxWaga { get; set; }
        public double? MaxObj { get; set; }
        public double? NaczMaxIlosc { get; set; }
        public double? NaczMaxWaga { get; set; }
        public double? NaczMaxObj { get; set; }
        public string Profil { get; set; }
        public int? Vip { get; set; }
        public int? Rezerwacja { get; set; }
        public string RezerwacjaTyp { get; set; }
        public DateTime? RezerwacjaOd { get; set; }
        public DateTime? RezerwacjaDo { get; set; }
        public int? RezerwacjaZLadunkiem { get; set; }
        public int? RezerwacjaMiejsceId { get; set; }
        public string RezerwacjaMiejsceKraj { get; set; }
        public double? RezerwacjaMiejsceLon { get; set; }
        public double? RezerwacjaMiejsceLat { get; set; }
        public string Lokalizacja { get; set; }
        public string LokalizacjaKraj { get; set; }
        public string OstRejestrPozTyp { get; set; }
        public int? OstRejestrPozid { get; set; }
        public DateTime? OstRejestrPoz { get; set; }
        public double? OstLon { get; set; }
        public double? OstLat { get; set; }
        public string KabotazKraj { get; set; }
        public int? KabotazIlosc { get; set; }
        public int? KabotazNaPusto { get; set; }
        public double? OstLatKier { get; set; }
        public double? OstLonKier { get; set; }
        public DateTime? OstRejestrPozKier { get; set; }
        public int? OstRejestrPozidKier { get; set; }
    }
}
