using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// pytania - pozycje definicji interfejsu
    /// </summary>
    public partial class SfmIcDefQuestion
    {
        public int IdSfmIcDefQuestion { get; set; }
        /// <summary>
        /// ID nagłówka
        /// </summary>
        public int? HeaderId { get; set; }
        /// <summary>
        /// liczba porządkowa
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// identyfikator pytania
        /// </summary>
        public string Qid { get; set; }
        /// <summary>
        /// tekst pytania
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// (0/1) pytanie ukryte
        /// </summary>
        public short? Hide { get; set; }
        /// <summary>
        /// rodzaj odpowiedzi (N-none/S-single/M-multi)
        /// </summary>
        public string SelModel { get; set; }
        /// <summary>
        /// domyślna odpowiedź z listy
        /// </summary>
        public string SelDefault { get; set; }
        /// <summary>
        /// następny punkt ścieżki pytań
        /// </summary>
        public string QidNext { get; set; }
        /// <summary>
        /// orginalny identyfikator pytania
        /// </summary>
        public string QidOrg { get; set; }
    }
}
