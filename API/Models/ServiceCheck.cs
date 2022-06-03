using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ServiceCheck
    {
        public int IdServiceCheck { get; set; }
        /// <summary>
        /// Kod serwisu
        /// </summary>
        public string ServiceCode { get; set; }
        /// <summary>
        /// Pełna nazwa serwisu
        /// </summary>
        public string ServiceName { get; set; }
        /// <summary>
        /// DataCzas ostatniego uruchomienia
        /// </summary>
        public DateTime? LastRun { get; set; }
        /// <summary>
        /// Liczba minut od ostatniej aktywności, która inicjuje alarm
        /// </summary>
        public int? AlarmAfter { get; set; }
    }
}
