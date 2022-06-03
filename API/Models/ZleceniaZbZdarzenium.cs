﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Zlecenia zbiorcze - zdarzenia
    /// </summary>
    public partial class ZleceniaZbZdarzenium
    {
        public int IdZleceniaZbZdarzenia { get; set; }
        public int? ZleceniaZbId { get; set; }
        public int? LpZleceniaZb { get; set; }
        public string Typ { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
        public string Miasto { get; set; }
        public string Kraj { get; set; }
        public string Telefony { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? GodzDo { get; set; }
        public int? KorGodz { get; set; }
        public DateTime? DyspGodzOd { get; set; }
        public DateTime? DyspGodzDo { get; set; }
        /// <summary>
        /// początkowy stan licznika kilometrów
        /// </summary>
        public double? LkmStart { get; set; }
        /// <summary>
        /// końcowy stan licznika kilometrów
        /// </summary>
        public double? Licznik { get; set; }
        public double? Waga { get; set; }
        public double? WagaRz { get; set; }
        public double? WagaZestawu { get; set; }
        public string JednWagi { get; set; }
        public double? Palety { get; set; }
        public double? IloscRz { get; set; }
        public double? PaletyWym { get; set; }
        public int? TypZ { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? Przeladunek { get; set; }
        public DateTime? DataRz { get; set; }
        public DateTime? GodzRz { get; set; }
        public DateTime? DataRzK { get; set; }
        public DateTime? GodzRzK { get; set; }
        public DateTime? DataRzP { get; set; }
        public DateTime? GodzRzP { get; set; }
        public string DodOpis { get; set; }
        public string DodOpisRz { get; set; }
        public double? Opoznienie { get; set; }
        public string OpoznieniePowod { get; set; }
        public int? LadunekId { get; set; }
        public string Ladunek { get; set; }
        public string TempPrzewozuO { get; set; }
        public string TempPrzewozuORz { get; set; }
        public string Jm { get; set; }
        /// <summary>
        /// zużyte paliwo w trakcie zdarzenia
        /// </summary>
        public double? Paliwo { get; set; }
        /// <summary>
        /// końcowy stan licznika paliwa
        /// </summary>
        public double? PaliwoLicznik { get; set; }
        public double? GeoLongi { get; set; }
        public double? GeoLat { get; set; }
        public double? GeoLongiRz { get; set; }
        public double? GeoLatRz { get; set; }
        public string InneUwagi { get; set; }
        public int? WysylacUwagi { get; set; }
        public int? TaborId { get; set; }
        public double? CzasTrwania { get; set; }
        public double? MaxOpozn { get; set; }
        public int? Pusty { get; set; }
        public int? KontenerId { get; set; }
        public string Kontener { get; set; }
        public int? Kontener2Id { get; set; }
        public string Kontener2 { get; set; }
        public int? AnulPw { get; set; }
        public int? Pietrowanie { get; set; }
        /// <summary>
        /// id definicji geofencingu (referencja do tabeli GF_DEF)
        /// </summary>
        public int? GfDefId { get; set; }
        public double? Dlugosc { get; set; }
        public double? Wysokosc { get; set; }
        public double? Szerokosc { get; set; }
        public double? Obj { get; set; }
        public double? Ldm { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public DateTime? DataRzW { get; set; }
        public DateTime? GodzRzW { get; set; }
        public DateTime? AwizacjaPrzed { get; set; }
    }
}
