using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiChecklist
    {
        public int IdPrzesylkiChecklist { get; set; }
        /// <summary>
        /// Relacja do zlecenia morskiego
        /// </summary>
        public int PrzesylkiId { get; set; }
        /// <summary>
        /// Relacja do pozycji checklisty
        /// </summary>
        public int Checklistdefid { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int Lp { get; set; }
        /// <summary>
        /// Flaga czy wykonano
        /// </summary>
        public int Completed { get; set; }
        /// <summary>
        /// DT kiedy wykonano
        /// </summary>
        public DateTime? Completeddt { get; set; }
        /// <summary>
        /// Uwagi
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// DT kiedy zmieniono
        /// </summary>
        public DateTime? Changedt { get; set; }
        /// <summary>
        /// User który wykonał zmianę
        /// </summary>
        public int? Changeuserid { get; set; }
        /// <summary>
        /// DT do kiedy
        /// </summary>
        public DateTime? ExpirationDt { get; set; }
    }
}
