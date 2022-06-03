using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// funkcja interfejsu po stronie SPEED
    /// </summary>
    public partial class SfmIcAction
    {
        public int IdSfmIcAction { get; set; }
        /// <summary>
        /// ID funkcji interfejsu
        /// </summary>
        public int? FunctionId { get; set; }
        /// <summary>
        /// (0/1) aktywny
        /// </summary>
        public short? Isactive { get; set; }
        /// <summary>
        /// identyfikator akcji funkcji
        /// </summary>
        public string Aid { get; set; }
        /// <summary>
        /// kolejność wykonywania
        /// </summary>
        public short? Actionindex { get; set; }
        /// <summary>
        /// rodzaj wykonywanej akcji (I-insert/U-update/S-skrypt/F-funkcja)
        /// </summary>
        public string Actiontype { get; set; }
        /// <summary>
        /// nazwa tabeli SPEED
        /// </summary>
        public string Tablename { get; set; }
        /// <summary>
        /// lista aktualizowanych pól tabeli
        /// </summary>
        public string Fieldlist { get; set; }
        /// <summary>
        /// warunek dla akcji &quot;update&quot;
        /// </summary>
        public string SqlWhere { get; set; }
        /// <summary>
        /// skrypt SQL
        /// </summary>
        public string Sql { get; set; }
        /// <summary>
        /// opis akcji funkcji
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        /// nazwa funkcji SPEED
        /// </summary>
        public string Functionname { get; set; }
    }
}
