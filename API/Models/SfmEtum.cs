using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmEtum
    {
        public int IdSfmEta { get; set; }
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
        /// 0/1-czy przetworzone/ 2-pominięte
        /// </summary>
        public short? Zrobione { get; set; }
        /// <summary>
        /// czas utworzenia / zapisu do BD
        /// </summary>
        public DateTime? DtSave { get; set; }
        /// <summary>
        /// czas zdarzenia
        /// </summary>
        public DateTime? DtEvent { get; set; }
        /// <summary>
        /// planowany termin dotarcia na miejsce
        /// </summary>
        public DateTime? DtEta { get; set; }
        /// <summary>
        /// obiekt - id tablicy
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id w obiekcie (patrz ID_OBJ)
        /// </summary>
        public int? IdRec { get; set; }
        /// <summary>
        /// id utworzonego alertu
        /// </summary>
        public int? IdSfmMsg { get; set; }
        /// <summary>
        /// gps:LON miejsca startowego
        /// </summary>
        public double? SrcLon { get; set; }
        /// <summary>
        /// gps:LAT miejsca startowego
        /// </summary>
        public double? SrcLat { get; set; }
        /// <summary>
        /// gps:LON miejsca docelowego
        /// </summary>
        public double? DestLon { get; set; }
        /// <summary>
        /// gps:LAT miejsca docelowego
        /// </summary>
        public double? DestLat { get; set; }
        /// <summary>
        /// odległość do miejsca docelowego
        /// </summary>
        public double? DestDist { get; set; }
        /// <summary>
        /// id kierowcy 2 SPEED
        /// </summary>
        public int? IdKierowcy2 { get; set; }
        /// <summary>
        /// wymagany czas dojazdu do miejsca docelowego [dni]
        /// </summary>
        public double? DriveTime { get; set; }
        /// <summary>
        /// oczekiwanie na zdarzenie w minutach
        /// </summary>
        public int? Wait { get; set; }
        /// <summary>
        /// spóźnienie na zdarzenie w minutach
        /// </summary>
        public int? Delay { get; set; }
    }
}
