using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// ReportSet-y dla obiektów
    /// </summary>
    public partial class ObjectReportSet
    {
        public int IdObjectReportSet { get; set; }
        /// <summary>
        /// Relacja do OBJECT
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>
        /// Relacja do ReportSet
        /// </summary>
        public int ReportSetId { get; set; }
        /// <summary>
        /// Nazwa setu
        /// </summary>
        public string Name { get; set; }
    }
}
