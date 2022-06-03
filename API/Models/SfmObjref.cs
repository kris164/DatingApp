using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// popwiącanie id obiektów SPEED z systemem zewnętrznym
    /// </summary>
    public partial class SfmObjref
    {
        public int IdSfmObjref { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public short IdSfmSystem { get; set; }
        /// <summary>
        /// rodzaj obiektu
        /// </summary>
        public string Objtype { get; set; }
        /// <summary>
        /// identyfikator w syst. InterLAN
        /// </summary>
        public string Objinternalid { get; set; }
        /// <summary>
        /// identyfikator w syst. zewnętrznym
        /// </summary>
        public string Objexternalid { get; set; }
        /// <summary>
        /// info dodatkowe do referencji
        /// </summary>
        public string ExtInfo { get; set; }
    }
}
