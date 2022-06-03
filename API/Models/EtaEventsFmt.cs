using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EtaEventsFmt
    {
        public int IdEtaEventsFmt { get; set; }
        /// <summary>
        /// symbol formatki zdarzenia
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// ID obiektu SPEED
        /// </summary>
        public int IdObj { get; set; }
        /// <summary>
        /// statusy (po przecinkach) wyzwalające zdarzenie
        /// </summary>
        public string Statuslist { get; set; }
        /// <summary>
        /// (0/1) akcja - utworz wiadomość
        /// </summary>
        public short? ActMsg { get; set; }
        /// <summary>
        /// ID wzorca do utworzenia wiadomości
        /// </summary>
        public int? IdObjWzorzec { get; set; }
        /// <summary>
        /// (0/1) utworz wiadomość typu alert
        /// </summary>
        public short? AlertMsg { get; set; }
        /// <summary>
        /// (0/1) akcja - wykonaj procedurę składowaną
        /// </summary>
        public short? ActProcedure { get; set; }
        /// <summary>
        /// nazwa procedury składowanej
        /// </summary>
        public string Procedura { get; set; }
        /// <summary>
        /// id procedury składowanej
        /// </summary>
        public int? ProceduraId { get; set; }
        /// <summary>
        /// opis zdarzenia
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// przesunięcie w minutach względem ETA_EVENTS.DT_Base
        /// </summary>
        public int? DeltaMin { get; set; }
        /// <summary>
        /// (0/1) akcja - utworz wiadomość SMS
        /// </summary>
        public short? ActSms { get; set; }
        /// <summary>
        /// ID wzorca wiadomości SMS
        /// </summary>
        public int? IdObjWzorzecSms { get; set; }
    }
}
