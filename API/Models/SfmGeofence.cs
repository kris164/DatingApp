using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmGeofence
    {
        public int IdSfmGeofence { get; set; }
        /// <summary>
        /// 0/1-czy przetworzone/ 2-pominięte
        /// </summary>
        public short? Zrobione { get; set; }
        /// <summary>
        /// relacja do tabeli GeoFencing (opcjonalnie)
        /// </summary>
        public int? IdGeofencing { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// id terminala
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// id pozycji GPS
        /// </summary>
        public int? IdSfmPos { get; set; }
        /// <summary>
        /// id utworzonego alertu
        /// </summary>
        public int? IdSfmMsg { get; set; }
        /// <summary>
        /// typ terminala
        /// </summary>
        public string TypTerm { get; set; }
        /// <summary>
        /// id taboru SPEED
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id naczepy taboru SPEED
        /// </summary>
        public int? IdNaczepy { get; set; }
        /// <summary>
        /// id kierowcy SPEED
        /// </summary>
        public int? IdKierowcy { get; set; }
        /// <summary>
        /// czas utworzenia / zapisu do BD
        /// </summary>
        public DateTime? DtSave { get; set; }
        /// <summary>
        /// czas zdarzenia
        /// </summary>
        public DateTime? DtEvent { get; set; }
        /// <summary>
        /// 0-wjazd/ 1-wyjazd/ 2-inne
        /// </summary>
        public short? GfEnterexit { get; set; }
        /// <summary>
        /// gps geofencingu: LON
        /// </summary>
        public double? GfLon { get; set; }
        /// <summary>
        /// gps geofencingu: LAT
        /// </summary>
        public double? GfLat { get; set; }
        /// <summary>
        /// 0-koło /1-prostokąt /2-nieregularny
        /// </summary>
        public short? GfRegion { get; set; }
        /// <summary>
        /// promień koła / 0.5 podstawy prostokąta (w metrach)
        /// </summary>
        public int? GfRadiusX { get; set; }
        /// <summary>
        /// 0.5 wysokości prostokąta (w metrach)
        /// </summary>
        public int? GfRadiusY { get; set; }
        /// <summary>
        /// gps zdarzenia: LON
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// gps zdarzenia: LAT
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// obiekt - id tablicy
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id w obiekcie (patrz ID_OBJ)
        /// </summary>
        public int? IdRec { get; set; }
        /// <summary>
        /// typ zewnętrznego id
        /// </summary>
        public string ExtIdTyp { get; set; }
        /// <summary>
        /// zewnętrzne id
        /// </summary>
        public string ExtId { get; set; }
        /// <summary>
        /// nazwa geofencingu
        /// </summary>
        public string ExtName { get; set; }
        /// <summary>
        /// treść alarmu z geofencingu dla kierowcy
        /// </summary>
        public string Drivermsg { get; set; }
        public int? StatusD { get; set; }
    }
}
