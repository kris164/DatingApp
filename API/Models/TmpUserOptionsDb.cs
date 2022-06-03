using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpUserOptionsDb
    {
        public int IdTmpUserOptionsDb { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdUserOptionsDb { get; set; }
        /// <summary>
        /// id użytkownika (-2:global/ -6:all_app/ -5:service/ -4:firm/ -3:computer)
        /// </summary>
        public int? IdUser { get; set; }
        /// <summary>
        /// nazwa aplikacji
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// nazwa sekcji opcji
        /// </summary>
        public string Section { get; set; }
        /// <summary>
        /// nazwa opcji (unikalna w ramach sekcji)
        /// </summary>
        public string OptName { get; set; }
        /// <summary>
        /// typ danych
        /// </summary>
        public string OptDataType { get; set; }
        /// <summary>
        /// wartość opcji
        /// </summary>
        public string OptValue { get; set; }
        /// <summary>
        /// opis opcji
        /// </summary>
        public string OptDesc { get; set; }
        /// <summary>
        /// grupa opcji
        /// </summary>
        public string OptGroup { get; set; }
        /// <summary>
        /// wyróżnik dla aktywnego działu
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// wyróżnik aktywności opcji
        /// </summary>
        public int? Active { get; set; }
    }
}
