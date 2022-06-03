using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// relacje między SFM_IC_Def_Header i SFM_IC_Function
    /// </summary>
    public partial class SfmIcInterface
    {
        public int IdSfmIcInterface { get; set; }
        /// <summary>
        /// ID funkcji interfejsu
        /// </summary>
        public int? FunctionId { get; set; }
        /// <summary>
        /// ID nagłówka definicji interfejsu
        /// </summary>
        public int? HeaderId { get; set; }
        /// <summary>
        /// (0/1) aktywny
        /// </summary>
        public short? Isactive { get; set; }
        /// <summary>
        /// symbol interfejsu
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// opis interfejsu
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        /// definicje powiązań interfejsu
        /// </summary>
        public string Xml { get; set; }
        /// <summary>
        /// czas utworzenia
        /// </summary>
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// czas ostatniej modyfikacji
        /// </summary>
        public DateTime? DtModify { get; set; }
        /// <summary>
        /// importowany - (0-nie/1-tak)
        /// </summary>
        public short? Isimported { get; set; }
    }
}
