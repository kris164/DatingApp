using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmAlert
    {
        public int IdSfmAlert { get; set; }
        /// <summary>
        /// 0/1-czy przetworzone/ 2-pominięte
        /// </summary>
        public short? Zrobione { get; set; }
        /// <summary>
        /// typ terminala
        /// </summary>
        public string TypTerm { get; set; }
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
        /// id utworzonego zdarzenia geofencingu
        /// </summary>
        public int? IdSfmGeofence { get; set; }
        /// <summary>
        /// czas utworzenia / zapisu do BD
        /// </summary>
        public DateTime? DtSave { get; set; }
        /// <summary>
        /// czas zdarzenia
        /// </summary>
        public DateTime? DtEvent { get; set; }
        /// <summary>
        /// gps zdarzenia: LON
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// gps zdarzenia: LAT
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// typ alarmu
        /// </summary>
        public string AlarmType { get; set; }
        /// <summary>
        /// treść alarmu
        /// </summary>
        public string AlarmMsg { get; set; }
    }
}
