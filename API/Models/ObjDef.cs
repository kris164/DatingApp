using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ObjDef
    {
        public int IdObjDef { get; set; }
        /// <summary>
        /// ID obiektu SPEED
        /// </summary>
        public int IdObj { get; set; }
        /// <summary>
        /// typ obiektu
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// tabela główna obiektu
        /// </summary>
        public string Tabela { get; set; }
        /// <summary>
        /// nazwa identyfikatora w tabeli głównej
        /// </summary>
        public string IdPole { get; set; }
        /// <summary>
        /// opis/nazwa obiektu
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// nazwa procedury składowanej generującej SMS dla obiektu
        /// </summary>
        public string GenerSmsProc { get; set; }
    }
}
