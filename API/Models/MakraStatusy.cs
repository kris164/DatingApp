using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MakraStatusy
    {
        public int IdMakraStatusy { get; set; }
        public int? Aktywne { get; set; }
        public string NrMakra { get; set; }
        public int? Obiekt { get; set; }
        public string SystZrodl { get; set; }
        public string Status { get; set; }
        public int? StatusSfm { get; set; }
        public string Telefon { get; set; }
        public string Uwagi { get; set; }
        public int? TelefonAktywny { get; set; }
        public string Procedura { get; set; }
        public int? ProceduraId { get; set; }
        public int? ProceduraAktywna { get; set; }
        /// <summary>
        /// ID wzorca do utworzenia wiadomości
        /// </summary>
        public int? IdObjWzorzec { get; set; }
        /// <summary>
        /// (0/1) utworz wiadomość typu alert
        /// </summary>
        public short? AlertMsg { get; set; }
        public string Funkcja { get; set; }
        public int? FunkcjaAktywna { get; set; }
    }
}
