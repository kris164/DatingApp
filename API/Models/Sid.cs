using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje SID - Schemty Importu Danych
    /// </summary>
    public partial class Sid
    {
        public int IdSid { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI (w SPEED nie wykorzystywane)
        /// </summary>
        public int? IdKlienta { get; set; }
        /// <summary>
        /// Nazwa schematu importu danych
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Format danych
        /// </summary>
        public int? Format { get; set; }
        /// <summary>
        /// Typ danych
        /// </summary>
        public int? Typ { get; set; }
        /// <summary>
        /// Kodowanie znaków
        /// </summary>
        public int? Znaki { get; set; }
        /// <summary>
        /// Flaga, czy plik zawiera nagłówek
        /// </summary>
        public int? Naglowek { get; set; }
        /// <summary>
        /// Flaga, czy plik zawiera stopkę
        /// </summary>
        public int? Stopka { get; set; }
        /// <summary>
        /// Domyślna ścieżka skąd pobierany będzie plik
        /// </summary>
        public string Sciezka { get; set; }
        /// <summary>
        /// Nazwa domyślnego pliku
        /// </summary>
        public string Plik { get; set; }
        /// <summary>
        /// Definicja SID
        /// </summary>
        public byte[] Skrypt { get; set; }
        /// <summary>
        /// Ścieżka archiwum
        /// </summary>
        public string ArchSciezka { get; set; }
        /// <summary>
        /// Flaga, czy przenosić do archiwum
        /// </summary>
        public int? ArchPrzenies { get; set; }
        /// <summary>
        /// Flaga, czy dodawać datę do nazwy przy przenoszeniu do archiwum
        /// </summary>
        public int? ArchZData { get; set; }
        /// <summary>
        /// Flaga, automatyczny odczyt danych z pliku bez potwierdzania
        /// </summary>
        public int? AutoOdczyt { get; set; }
        /// <summary>
        /// Flaga, automatyczny zapis danych do bazy bez potwierdzania
        /// </summary>
        public int? AutoZapis { get; set; }
        /// <summary>
        /// Nazwa procedury skladowanej wykorzystywanej jako czarna skrzynka poza zapisie rekordu danych do bazy
        /// </summary>
        public string Procedura { get; set; }
        /// <summary>
        /// Flaga czy aktualizować istniejące już rekordy w bazie danych 
        /// </summary>
        public int? CzyUpdate { get; set; }
        /// <summary>
        /// Flaga czy wywolac procedure skladowana dla kazdego z zapisanych przez SID rekordow
        /// </summary>
        public int? CzyProcedura { get; set; }
        /// <summary>
        /// Flaga czy wywolac procedure cennika dla kazdego z zapisanych przez SID rekordow
        /// </summary>
        public int? CzyCennikSql { get; set; }
        /// <summary>
        /// Id cennika wykorzystywanego po zapisie rekordu danych do bazy
        /// </summary>
        public int? CennikSqlId { get; set; }
        /// <summary>
        /// Nazwa cennika wykorzystywanego po zapisie rekordu danych do bazy
        /// </summary>
        public string CennikSql { get; set; }
        /// <summary>
        /// Flaga czy sid ma byc wykorzystywany przez serwer edi
        /// </summary>
        public int? CzyEdi { get; set; }
        /// <summary>
        /// Flaga czy dane maja podlegac dodatkowej walidacji
        /// </summary>
        public int? CzyWalidacja { get; set; }
        /// <summary>
        /// Flaga, czy skopiowac do archiwum
        /// </summary>
        public int? ArchKopiuj { get; set; }
        /// <summary>
        /// Flaga czy zadluzenie kontrahenta ma podlegac walidacji
        /// </summary>
        public int? CzyZadluzenie { get; set; }
        /// <summary>
        /// separator pliku
        /// </summary>
        public string Separator { get; set; }
        /// <summary>
        /// Przepisanie gps z POI na ZA WY
        /// </summary>
        public int? PoiGps { get; set; }
        /// <summary>
        /// Typ danych widoczny dla typu dowolny
        /// </summary>
        public string TypDowolny { get; set; }
        /// <summary>
        /// Ścieżka blad
        /// </summary>
        public string ArchSciezkaBlad { get; set; }
        public int? GdprSourceId { get; set; }
    }
}
