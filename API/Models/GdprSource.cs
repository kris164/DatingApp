using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Źródła danych osobowych
    /// </summary>
    public partial class GdprSource
    {
        public int IdGdprSource { get; set; }
        /// <summary>
        /// CODE of GDPR SOURCE e.g. WMS
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// DECRIPTION of GDPR SOURCE e.g. from WMS system
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// REMARKS of GDPR SOURCE e.g. source strictly def. in WMS system
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// ACTIVE available to use
        /// </summary>
        public int? Active { get; set; }
        /// <summary>
        /// SYSTEM defined by system - change not allowed
        /// </summary>
        public int? System { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
