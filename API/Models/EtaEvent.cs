using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EtaEvent
    {
        public int IdEtaEvents { get; set; }
        /// <summary>
        /// ID obiektu SPEED
        /// </summary>
        public int IdObj { get; set; }
        /// <summary>
        /// ID rekordu obiektu
        /// </summary>
        public int IdRec { get; set; }
        /// <summary>
        /// czas uruchomienia zdarzenia (DT_ETA = DT_Base + OneMinute*Delta_Min)
        /// </summary>
        public DateTime? DtEta { get; set; }
        /// <summary>
        /// czas wygaśnięcia
        /// </summary>
        public DateTime? DtExpire { get; set; }
        /// <summary>
        /// czas nadania statusu
        /// </summary>
        public DateTime? DtStatus { get; set; }
        /// <summary>
        /// 0-nowy/10-wykonany/20-anulowany/30-wygasł/99-blad
        /// </summary>
        public short? Status { get; set; }
        /// <summary>
        /// treść błędu podczas wykonywania akcji zdarzenia
        /// </summary>
        public string ErrorMsg { get; set; }
        /// <summary>
        /// planowana pozycja GPS (+/-)E/W
        /// </summary>
        public double? EtaLon { get; set; }
        /// <summary>
        /// planowana pozycja GPS (+/-)N/S
        /// </summary>
        public double? EtaLat { get; set; }
        /// <summary>
        /// formatka definicji wyzwalacza i akcji
        /// </summary>
        public int? IdEtaEventsFmt { get; set; }
        /// <summary>
        /// status, który wyzwolił zdarzenie
        /// </summary>
        public string SrcStatus { get; set; }
        /// <summary>
        /// czas utworzenia
        /// </summary>
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// czas ostatniej modyfikacji
        /// </summary>
        public DateTime? DtModify { get; set; }
        /// <summary>
        /// ID utworzonej wiadomości
        /// </summary>
        public int? IdSfmMsg { get; set; }
        /// <summary>
        /// ID pozycji najbliższej czasowo
        /// </summary>
        public int? IdSfmPos { get; set; }
        /// <summary>
        /// opis zdarzenia
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// przesunięcie w minutach względem DT_Base
        /// </summary>
        public int? DeltaMin { get; set; }
        /// <summary>
        /// czas bazowy obiektu z ID_REC
        /// </summary>
        public DateTime? DtBase { get; set; }
        /// <summary>
        /// ID utworzonej wiadomości SMS
        /// </summary>
        public int? IdSfmSms { get; set; }
    }
}
