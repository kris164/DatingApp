using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborHistlog
    {
        public int IdTaborHistlog { get; set; }
        /// <summary>
        /// ID pojazdu
        /// </summary>
        public int IdTabor { get; set; }
        /// <summary>
        /// ID kierowcy
        /// </summary>
        public int? IdKierowca { get; set; }
        /// <summary>
        /// czas zdarzenia
        /// </summary>
        public DateTime? DtInfo { get; set; }
        /// <summary>
        /// czas pierwszego zapisu zdarzenia
        /// </summary>
        public DateTime? DtZapis { get; set; }
        /// <summary>
        /// czas potwierdzenia/anulowania zdarzenia
        /// </summary>
        public DateTime? DtKoniec { get; set; }
        /// <summary>
        /// rodzaj zdarzenia
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// opis/temat/parametry
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// dodatkowy opis/parametry
        /// </summary>
        public string InfoEx { get; set; }
        /// <summary>
        /// ID zlecenia
        /// </summary>
        public int? IdZlecenia { get; set; }
        /// <summary>
        /// ID zdarzenia zlecenia
        /// </summary>
        public int? IdZleceniaZaWy { get; set; }
        /// <summary>
        /// 0/1/2 - nowe/zatwierdzone/anulowane (wartości ujemne, to statusy nadawane automatycznie)
        /// </summary>
        public short? Zrobione { get; set; }
        /// <summary>
        /// licznik kilometrów
        /// </summary>
        public double? Lkm { get; set; }
        /// <summary>
        /// Automat(0/1): nowe/obsłużone
        /// </summary>
        public short? Automat { get; set; }
        /// <summary>
        /// ilość towaru
        /// </summary>
        public double? Ilosc { get; set; }
        /// <summary>
        /// jednostka ilości
        /// </summary>
        public string Jm { get; set; }
        /// <summary>
        /// ID wiadomości
        /// </summary>
        public int? IdSfmMsg { get; set; }
    }
}
