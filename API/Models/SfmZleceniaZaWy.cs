using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmZleceniaZaWy
    {
        public int IdZleceniaZaWy { get; set; }
        /// <summary>
        /// 0-nowy/ 1-przetworzony/ 2-przypisany/ 3-anulowany
        /// </summary>
        public short? Status { get; set; }
        /// <summary>
        /// typ terminala (operator)
        /// </summary>
        public string TypTerm { get; set; }
        /// <summary>
        /// id terminala
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// id taboru
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id naczepy
        /// </summary>
        public int? IdNaczepa { get; set; }
        /// <summary>
        /// id kierowcy
        /// </summary>
        public int? IdKierowcy { get; set; }
        /// <summary>
        /// id utworzonej wiadomości
        /// </summary>
        public int? IdSfmMsg { get; set; }
        /// <summary>
        /// data utworzenia
        /// </summary>
        public DateTime? Dt { get; set; }
        /// <summary>
        /// numer nadany przez kierowcę
        /// </summary>
        public string Numer { get; set; }
        /// <summary>
        /// id w syst. zewnętrznym
        /// </summary>
        public string ExtId { get; set; }
        /// <summary>
        /// rodzaj aktywności - nr
        /// </summary>
        public string ExtTyp { get; set; }
        /// <summary>
        /// rodzaj aktywności - opis
        /// </summary>
        public string ExtTypOpis { get; set; }
        /// <summary>
        /// zawartość źródła XML zdarzenia
        /// </summary>
        public string Xml { get; set; }
        /// <summary>
        /// id powiązanego raportu z danymi
        /// </summary>
        public int? IdSfmIcFiles { get; set; }
    }
}
