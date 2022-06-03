using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PwKartum
    {
        public int IdPwKarta { get; set; }
        public short? Status { get; set; }
        public int? IdWyjazdy { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public int? IdSfmTerm { get; set; }
        public string TypTerm { get; set; }
        public int? IdTabor { get; set; }
        public int? IdKierowcy { get; set; }
        public DateTime? DtSave { get; set; }
        public DateTime? DtCreate { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtStop { get; set; }
        public string ExtDevice { get; set; }
        public string ExtDriver { get; set; }
        public string ExtId { get; set; }
        public string ExtName { get; set; }
        public string ExtInfo { get; set; }
        public string ExtData { get; set; }
    }
}
