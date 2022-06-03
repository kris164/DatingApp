using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class NotySplaty
    {
        public int IdNotySplaty { get; set; }
        public int NotyId { get; set; }
        public DateTime DataSplaty { get; set; }
        public string NrWyciagu { get; set; }
        public double KwotaSplaty { get; set; }
        public int? KursyWalutId { get; set; }
        public string NrTabeliKursow { get; set; }
        public double? KursWaluty { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public int? KompensatyId { get; set; }
        public int? KomunikacjaFkRkId { get; set; }
        /// <summary>
        /// Retacja do użytkownika rej. spłate - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Nazwa użytkwnika
        /// </summary>
        public string Uzytkownik { get; set; }
        public int? PrzelewyDokId { get; set; }
    }
}
