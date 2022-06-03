using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Zlp
    {
        public int IdZlp { get; set; }
        public string NrZlp { get; set; }
        public int? NrZlpKolejny { get; set; }
        public int? NrZlpRok { get; set; }
        public int? NrZlpMies { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? ListyLinioweZaWyId { get; set; }
        public int? ListyLinioweWyId { get; set; }
        public string Lokalizacja { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientOdbSymbol { get; set; }
        public DateTime? DataUtworzenia { get; set; }
        public int? Anulowany { get; set; }
        public string KodKreskowy { get; set; }
        public int? UzupDaneMaxId { get; set; }
        public string StatusEmisja { get; set; }
        public DateTime? DataDoreczenia { get; set; }
        public DateTime? GodzDoreczenia { get; set; }
        public string OsobaOdbiorca { get; set; }
        public int? Potwierdzony { get; set; }
        public string Status { get; set; }
        /// <summary>
        /// Relacja do użytkownika tworzącego rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? CreateIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika tworzącego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data utworzenia
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Godzina utworzenia
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Relacja do użytkownika który ostatni modyfikował rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? ModifyIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika modyfikującego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Godzina ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        public DateTime? DataPodjecia { get; set; }
        public DateTime? GodzPodjecia { get; set; }
        public int? Zafakturowane { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public int? IlePrzesOrg { get; set; }
        public int? IlePrzes { get; set; }
        public DateTime? PDataPodjecia { get; set; }
        public DateTime? PGodzPodjecia { get; set; }
        public DateTime? PDataDoreczenia { get; set; }
        public DateTime? PGodzDoreczenia { get; set; }
        public int? Zalaczniki { get; set; }
    }
}
