using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// pliki obrabiane przez interfejs
    /// </summary>
    public partial class SfmIcFile
    {
        public int IdSfmIcFiles { get; set; }
        /// <summary>
        /// identyfikator definicji
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// wersja definicji
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// id terminala SFM
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// typ terminala - kod operatora
        /// </summary>
        public string Termtype { get; set; }
        /// <summary>
        /// symbol terminala w syst. zewnętrznym
        /// </summary>
        public string Termid { get; set; }
        /// <summary>
        /// id pojazdu - tabor SPEED
        /// </summary>
        public int? IdVehicle { get; set; }
        /// <summary>
        /// id naczepy/przyczepy - tabor SPEED
        /// </summary>
        public int? IdTrailer { get; set; }
        /// <summary>
        /// id kierowcy SPEED
        /// </summary>
        public int? IdDriver { get; set; }
        /// <summary>
        /// id obiektu SPEED
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id rekordu obiektu SPEED
        /// </summary>
        public int? IdRec { get; set; }
        /// <summary>
        /// id pozycji GPS
        /// </summary>
        public int? IdSfmPos { get; set; }
        /// <summary>
        /// zdarzenie: ID
        /// </summary>
        public string IdEvent { get; set; }
        /// <summary>
        /// zdarzenie: czas wystąpienia
        /// </summary>
        public DateTime? DtEvent { get; set; }
        /// <summary>
        /// czas rejestracji w bazie SPEED
        /// </summary>
        public DateTime? DtSave { get; set; }
        /// <summary>
        /// czas przetwarzania danych
        /// </summary>
        public DateTime? DtExec { get; set; }
        /// <summary>
        /// czas wykontwania przetwarzania [ms]
        /// </summary>
        public int? Exectime { get; set; }
        /// <summary>
        /// status/folder pliku - (0-nowe/10-Wczytane/20-Inne/99-Bledy)
        /// </summary>
        public short? Status { get; set; }
        /// <summary>
        /// nazwa pliku z danymi
        /// </summary>
        public string Filename { get; set; }
        /// <summary>
        /// ID źródłowe (format: &quot;M:id&quot;)
        /// </summary>
        public string IdExt { get; set; }
        /// <summary>
        /// katalog do dziennego grupowania plików
        /// </summary>
        public string Folder { get; set; }
        public string IdRef { get; set; }
        public byte[] ReportXml { get; set; }
        public byte[] LogXml { get; set; }
        public byte[] TraceXml { get; set; }
    }
}
