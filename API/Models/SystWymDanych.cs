using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SystWymDanych
    {
        public int IdSystWymDanych { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public string Typ { get; set; }
        public int? GenerujAlert { get; set; }
        public int? GenerujEmail { get; set; }
        public int? GenerujPopup { get; set; }
        public string EmailLokalizacja { get; set; }
        public string EmailOdbiorcy { get; set; }
        public string PopupUsers { get; set; }
        /// <summary>
        /// Nazwa procedury skladowanej wykorzystywanej jako czarna skrzynka po zapisie rekordu danych do bazy
        /// </summary>
        public string Procedura { get; set; }
        /// <summary>
        /// Flaga czy wywolac procedure skladowana dla kazdego z zapisanych przez system rekordow
        /// </summary>
        public int? CzyProcedura { get; set; }
    }
}
