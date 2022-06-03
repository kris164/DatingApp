using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmEventParam
    {
        public int IdSfmEventParam { get; set; }
        /// <summary>
        /// id taboru SPEED
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id terminala
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// typ terminala
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// czas rejestracji
        /// </summary>
        public DateTime? DtRej { get; set; }
        /// <summary>
        /// E-Event; P-Param
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// kod zdarzenia/parametru
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// id pozycji gps
        /// </summary>
        public int? IdSfmPos { get; set; }
        /// <summary>
        /// wartość parametru
        /// </summary>
        public string Wartosc { get; set; }
    }
}
