using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RaportyKasowe
    {
        public int IdRaportyKasowe { get; set; }
        public string RapKasNr { get; set; }
        public int? RapKasKolejny { get; set; }
        public int? RapKasRok { get; set; }
        public int? RapKasMies { get; set; }
        public int? KasaId { get; set; }
        public string Kasa { get; set; }
        public string Waluta { get; set; }
        public string Status { get; set; }
        public double? StanPoczatkowy { get; set; }
        public double? StanWn { get; set; }
        public double? StanMa { get; set; }
        public double? Saldo { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DataDo { get; set; }
        public int? EksportFkId { get; set; }
        public int? ZamknBezSpec { get; set; }
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
    }
}
