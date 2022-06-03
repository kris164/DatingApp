using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// lista wysyłki/przetwarzania geofencingu
    /// </summary>
    public partial class GfSendList
    {
        public int IdGfSendList { get; set; }
        /// <summary>
        /// typ obiektu (11-LISTY_LINIOWE_ZA_WY /12-ZLECENIA_ZA_WY /200-GF_EVENT_DEF)
        /// </summary>
        public int? ObjTyp { get; set; }
        /// <summary>
        /// id obiektu SPEED (GF_EVENT_DEF_ID = [OBJ_TYP;REC_ID])
        /// </summary>
        public int? RecId { get; set; }
        /// <summary>
        /// id monitorowanego pojazdu
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// id terminala, do którego należy wysłać geofencing (-1 - obsługa wewnętrzna)
        /// </summary>
        public int? SfmTermId { get; set; }
        /// <summary>
        /// akcja/status geofencingu na pojeździe: /N-one - przygotowywanie do wysyłki (lub do przetwarzania gdy SFM_TERM_ID = -1) /S-end - wyślij do terminala pojazdu (po wysyłce: R-eady(OK) lub E-rror(błąd)) /C-ancel - anuluj na terminalu pojazdu (po wysyłce: D-isabled(OK) lub E-rror(błąd)) /R-eady - gotowe po wysyłce lub gotowe do przetwarzania wewnętrznego /D-isabled - nieaktywne po anulowaniu /E-rror - po błędnej akcji Send lub Cancel
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// data wysyłki geofencingu do terminala
        /// </summary>
        public DateTime? DtSend { get; set; }
        /// <summary>
        /// status wysyłki do terminala (0-brak /10-wysyłka /20-zakończono /99-błąd)
        /// </summary>
        public short? StatSend { get; set; }
        /// <summary>
        /// data wysyłki anulowania geofencingu na terminalu
        /// </summary>
        public DateTime? DtCancel { get; set; }
        /// <summary>
        /// status anulowania na terminalu (0-brak /10-wysyłka /20-zakończono /99-błąd)
        /// </summary>
        public short? StatCancel { get; set; }
        /// <summary>
        /// tekst błędu podczas wysyłki/przetwarzania
        /// </summary>
        public string ErrorTxt { get; set; }
        /// <summary>
        /// id w systemie zewnętrznym - wjazd do obszaru &lt;gf-received&gt;
        /// </summary>
        public string ExtIdEnter { get; set; }
        /// <summary>
        /// id w systemie zewnętrznym - wyjazd z obszaru &lt;gf-received&gt;
        /// </summary>
        public string ExtIdExit { get; set; }
        /// <summary>
        /// id w systemie zewnętrznym - przekroczenie czasu pobytu &lt;gf-received&gt;
        /// </summary>
        public string ExtIdDuration { get; set; }
        /// <summary>
        /// data wysyłki anulowania/skasowania geofencingu na terminalu
        /// </summary>
        public DateTime? DtDelete { get; set; }
        /// <summary>
        /// status usunięcia geofencingu (0-brak /30-do anulowania /40-do usunięcia /50-usunięte /99-błąd)
        /// </summary>
        public short? StatDelete { get; set; }
        /// <summary>
        /// data ostatniej modyfikacji rekordu
        /// </summary>
        public DateTime? DtModify { get; set; }
        /// <summary>
        /// status wysyłki zdarzenia ENTER (0-brak /10-utworzone /20-wysłane /99-błąd)
        /// </summary>
        public short? SendEnter { get; set; }
        /// <summary>
        /// status wysyłki zdarzenia EXIT (0-brak /10-utworzone /20-wysłane /99-błąd)
        /// </summary>
        public short? SendExit { get; set; }
        /// <summary>
        /// status wysyłki zdarzenia DURATION (0-brak /10-utworzone /20-wysłane /99-błąd)
        /// </summary>
        public short? SendDuration { get; set; }
        /// <summary>
        /// status anulowania zdarzenia ENTER (0-brak /10-zgłoszone /20-anulowane /99-błąd)
        /// </summary>
        public short? CancelEnter { get; set; }
        /// <summary>
        /// status anulowania zdarzenia EXIT (0-brak /10-zgłoszone /20-anulowane /99-błąd)
        /// </summary>
        public short? CancelExit { get; set; }
        /// <summary>
        /// status anulowania zdarzenia DURATION (0-brak /10-zgłoszone /20-anulowane /99-błąd)
        /// </summary>
        public short? CancelDuration { get; set; }
    }
}
