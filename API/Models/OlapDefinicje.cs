using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapDefinicje
    {
        public int IdOlapDefinicje { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Grupa { get; set; }
        public string DefinicjaSql { get; set; }
        public string DefinicjaSqlSp { get; set; }
        public int? ExecOk { get; set; }
        public int? DomyslnyWidok { get; set; }
        public int? Systemowy { get; set; }
        public string Wersja { get; set; }
        public DateTime? WersjaDataGodzUtw { get; set; }
        public int? DbEngine { get; set; }
        public string OlapDefCols { get; set; }
        public string OlapDefRows { get; set; }
        public string OlapDefSums { get; set; }
        public string OlapDefAgreg { get; set; }
        public int? Aktywny { get; set; }
        public string Instrukcje { get; set; }
        public int? WczytZapisany { get; set; }
        public int? Www { get; set; }
        public string ColsCrc { get; set; }
        public string PrinterSetup { get; set; }
        public int? OlapHideColTotals { get; set; }
        public int? OlapHideRowTotals { get; set; }
        public int? OlapHideColGtotals { get; set; }
        public int? OlapHideRowGtotals { get; set; }
        public string ExportEndpoint { get; set; }
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
        public string DefinicjaSqlSm { get; set; }
        public int? Kontekstowy { get; set; }
        public string DataSrc { get; set; }
        public int? NoSaveGridLayout { get; set; }
        public int? AllGridRecords { get; set; }
    }
}
