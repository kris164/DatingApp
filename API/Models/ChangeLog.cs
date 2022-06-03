using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Logi systemowe - zmiany
    /// </summary>
    public partial class ChangeLog
    {
        public int IdChangeLog { get; set; }
        /// <summary>
        /// Relacja do logu - tab: LOGI
        /// </summary>
        public int LogId { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
