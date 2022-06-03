using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertyNewPoz
    {
        public int IdOfertyNewPoz { get; set; }
        /// <summary>
        /// Relacja do przesyłki - tab: OFERTY_NEW
        /// </summary>
        public int OfertyNewId { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int Lp { get; set; }
        /// <summary>
        /// Relacja do OBJECT
        /// </summary>
        public int ObjId { get; set; }
        /// <summary>
        /// Relacja do konkretnego obiektu
        /// </summary>
        public int RecId { get; set; }
    }
}
