using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// definicja typu tabeli
    /// </summary>
    public partial class TabkursowDef
    {
        public int IdTabkursowDef { get; set; }
        /// <summary>
        /// typ tabeli (liczone od 3)
        /// </summary>
        public short? Typ { get; set; }
        /// <summary>
        /// symbol tabeli - nazwa zakładki na liście tabel kursów
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// opis tabeli
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// waluta bazowa tabeli (domyślnie PLN)
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// nie pokazuj zakładki
        /// </summary>
        public short? Ukryj { get; set; }
        /// <summary>
        /// 0/1 - włącza obsługę kursu średniego
        /// </summary>
        public short? Kurs { get; set; }
        /// <summary>
        /// 0/1 - włącza obsługę kursu kupna
        /// </summary>
        public short? Kupno { get; set; }
        /// <summary>
        /// 0/1 - włącza obsługę kursu sprzedaży
        /// </summary>
        public short? Sprzedaz { get; set; }
    }
}
