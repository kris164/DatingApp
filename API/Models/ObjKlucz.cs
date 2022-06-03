using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ObjKlucz
    {
        public int IdObjKlucz { get; set; }
        /// <summary>
        /// ID definicji obiektu SPEED
        /// </summary>
        public int IdObjDef { get; set; }
        /// <summary>
        /// nazwa klucza
        /// </summary>
        public string Klucz { get; set; }
        /// <summary>
        /// nazwa pola w tabeli głównej
        /// </summary>
        public string Pole { get; set; }
        /// <summary>
        /// opis klucza
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// przykładowa wartość
        /// </summary>
        public string Wartosc { get; set; }
    }
}
