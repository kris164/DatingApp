using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiChecklist
    {
        public int IdTmpPrzesylkiChecklist { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? Checklistdefid { get; set; }
        public int? Lp { get; set; }
        public int? Completed { get; set; }
        public DateTime? Completeddt { get; set; }
        public string Description { get; set; }
        public DateTime? Changedt { get; set; }
        public int? Changeuserid { get; set; }
        public DateTime? ExpirationDt { get; set; }
    }
}
