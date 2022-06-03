using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// pytania - pozycje definicji interfejsu
    /// </summary>
    public partial class SfmIcDefOption
    {
        public int IdSfmIcDefOption { get; set; }
        /// <summary>
        /// ID nagłówka
        /// </summary>
        public int? HeaderId { get; set; }
        /// <summary>
        /// ID pytania
        /// </summary>
        public int? QuestionId { get; set; }
        /// <summary>
        /// liczba porządkowa
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// identyfikator odpowiedzi
        /// </summary>
        public string Oid { get; set; }
        /// <summary>
        /// tekst przy odpowiedzi
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// (0/1) odpowiedź ukryta
        /// </summary>
        public short? ValHide { get; set; }
        /// <summary>
        /// typ wartości
        /// </summary>
        public short? ValType { get; set; }
        /// <summary>
        /// wartość domyślna
        /// </summary>
        public string ValDefault { get; set; }
        /// <summary>
        /// następny punkt ścieżki pytań
        /// </summary>
        public string QidNext { get; set; }
    }
}
