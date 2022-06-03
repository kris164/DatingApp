﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpTaborTermin
    {
        public int IdTmpTaborTermin { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdTaborTermin { get; set; }
        public int? TaborId { get; set; }
        public string CzynnoscId { get; set; }
        public string Czynnosc { get; set; }
        public string Wskaznik { get; set; }
        public DateTime? Data { get; set; }
        public int? Licznik { get; set; }
        public int? Interwal { get; set; }
        public string Uwagi { get; set; }
        public int? Weryfikacja { get; set; }
    }
}
