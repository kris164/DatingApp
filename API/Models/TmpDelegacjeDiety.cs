using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpDelegacjeDiety
    {
        public int IdTmpDelegacjeDiety { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdDelegacjeDiety { get; set; }
        /// <summary>
        /// Relacja do nagłówka delegacji, tab: DELEGACJE
        /// </summary>
        public int? DelegacjaId { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Kraj odcinka - symbol ISO
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Kraj odcinka - słownie
        /// </summary>
        public string KrajSl { get; set; }
        /// <summary>
        /// Data od
        /// </summary>
        public DateTime? DataStart { get; set; }
        /// <summary>
        /// Data do
        /// </summary>
        public DateTime? DataStop { get; set; }
        /// <summary>
        /// Godzina od
        /// </summary>
        public DateTime? GodzStart { get; set; }
        /// <summary>
        /// Godzina do
        /// </summary>
        public DateTime? GodzStop { get; set; }
        /// <summary>
        /// Ilość dob
        /// </summary>
        public int? Doby { get; set; }
        /// <summary>
        /// Ilość godzin
        /// </summary>
        public double? Godziny { get; set; }
        /// <summary>
        /// Ilość noclegów
        /// </summary>
        public int? Noclegi { get; set; }
        /// <summary>
        /// Ilość noclegów - backup na potrzeby kontroli
        /// </summary>
        public int? NoclegiBkp { get; set; }
        /// <summary>
        /// Ilość diet
        /// </summary>
        public double? DietaIlosc { get; set; }
        /// <summary>
        /// Waluta diet
        /// </summary>
        public string DietaWaluta { get; set; }
        /// <summary>
        /// Stawka dla 1 diety
        /// </summary>
        public double? DietaStawka { get; set; }
        /// <summary>
        /// Stawka 1 noclegu
        /// </summary>
        public double? NoclegStawka { get; set; }
        /// <summary>
        /// Łącznie diety
        /// </summary>
        public double? Dieta { get; set; }
        /// <summary>
        /// Łącznie noclegi
        /// </summary>
        public double? Nocleg { get; set; }
        /// <summary>
        /// Inne koszty
        /// </summary>
        public double? Inne { get; set; }
        /// <summary>
        /// Diety dla odcinka razem
        /// </summary>
        public double? DietyRazem { get; set; }
        /// <summary>
        /// Miasto
        /// </summary>
        public string Miasto { get; set; }
        /// <summary>
        /// RABEN - typ stawki - S - stała, M - malejaca
        /// </summary>
        public string RabTypStawki { get; set; }
    }
}
