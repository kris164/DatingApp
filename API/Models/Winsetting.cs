using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Winsetting
    {
        public int IdWinsettings { get; set; }
        /// <summary>
        /// klasa okna
        /// </summary>
        public string Winclass { get; set; }
        /// <summary>
        /// podtyp okna
        /// </summary>
        public int? Wintype { get; set; }
        /// <summary>
        /// tryb wyświetlania
        /// </summary>
        public string Wintryb { get; set; }
        /// <summary>
        /// id użytkownika
        /// </summary>
        public int? IdUser { get; set; }
        /// <summary>
        /// ustawienia listy typu dxGRID
        /// </summary>
        public string Xml { get; set; }
        /// <summary>
        /// wersja językowa
        /// </summary>
        public string Lang { get; set; }
    }
}
