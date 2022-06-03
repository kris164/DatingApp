using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EDokHist
    {
        public int IdEDokHist { get; set; }
        public string ObiektTyp { get; set; }
        public int ObiektId { get; set; }
        public int Status { get; set; }
        /// <summary>
        /// Retacja do użytkownika rej. spłate - tab: UZYTKOWNIK
        /// </summary>
        public int UzytkownikId { get; set; }
        /// <summary>
        /// Nazwa użytkwnika
        /// </summary>
        public string Uzytkownik { get; set; }
        public DateTime DataGodz { get; set; }
        public string AppName { get; set; }
        public string AppVer { get; set; }
        public string Info { get; set; }
    }
}
