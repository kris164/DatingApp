using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// log zdarzeń geofencingu
    /// </summary>
    public partial class LogGf
    {
        public int IdLogGf { get; set; }
        /// <summary>
        /// typ operacji (INS /UPD /DEL /SEND /CANCEL /ENTER /EXIT /DURATION /ETA)
        /// </summary>
        public string LogAction { get; set; }
        /// <summary>
        /// typ obiektu (11-LISTY_LINIOWE_ZA_WY /12-ZLECENIA_ZA_WY /200-GF_EVENT_DEF)
        /// </summary>
        public int? ObjTyp { get; set; }
        /// <summary>
        /// id obiektu SPEED (GF_EVENT_DEF_ID = [OBJ_TYP;REC_ID])
        /// </summary>
        public int? RecId { get; set; }
        /// <summary>
        /// id rekordu wysyłki/przetwarzania (0 - jeśli nie dotyczy)
        /// </summary>
        public int? GfSendListId { get; set; }
        /// <summary>
        /// id terminala (-1 - jeśli obsługa wewnętrzna)
        /// </summary>
        public int? SfmTermId { get; set; }
        /// <summary>
        /// id utworzonej wiadomości w tabeli SFM_MSG (0 - jeśli nie dotyczy)
        /// </summary>
        public int? SfmMsgId { get; set; }
        /// <summary>
        /// id pojazdu (0 - jeśli dotyczy ogólnie definicji geofencingu)
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// id naczepy
        /// </summary>
        public int? NaczepaId { get; set; }
        /// <summary>
        /// id kierowcy
        /// </summary>
        public int? KierowcaId { get; set; }
        /// <summary>
        /// data utworzenia wpisu w logu
        /// </summary>
        public DateTime? DtLog { get; set; }
        /// <summary>
        /// data zdarzenia
        /// </summary>
        public DateTime? DtEvent { get; set; }
        /// <summary>
        /// id w systemie zewnętrznym (analogia do GF_SEND_LIST.EXT_ID_xxxx)
        /// </summary>
        public string ExtId { get; set; }
        /// <summary>
        /// długość geograficzna wystąpienia zdarzenia
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// szerokość geograficzna wystąpienia zdarzenia
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// opis logowanego zdarzenia
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// status obsługi geofencingu (0-brak /1-wykonane /99-błąd)
        /// </summary>
        public short? GfStatus { get; set; }
        /// <summary>
        /// tekst błędu podczas obsługi geofencingu
        /// </summary>
        public string GfError { get; set; }
    }
}
