using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// definicja akcji dla zdarzenia geofencingu
    /// </summary>
    public partial class GfAction
    {
        public int IdGfAction { get; set; }
        /// <summary>
        /// typ obiektu (201-LOG_GF /200-GF_EVENT_DEF /12-ZLECENIA_ZA_WY /11-LISTY_LINIOWE_ZA_WY)
        /// </summary>
        public int? ObjTyp { get; set; }
        /// <summary>
        /// opis akcji
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        /// id formatki wiadomości do bazy
        /// </summary>
        public int? MsgTobaseId { get; set; }
        /// <summary>
        /// wiadomość do bazy (Msg_ToBase_ID=0) &lt;gf-send&gt;
        /// </summary>
        public string MsgTobaseTxt { get; set; }
        /// <summary>
        /// id formatki wiadomości do kierowcy
        /// </summary>
        public int? MsgTodriverId { get; set; }
        /// <summary>
        /// wiadomość do kierowcy (Msg_ToDriver_ID=0) &lt;gf-send&gt;
        /// </summary>
        public string MsgTodriverTxt { get; set; }
        /// <summary>
        /// 0/1 - zasygnalizuj kierowcy dźwiękiem &lt;gf-send&gt;
        /// </summary>
        public short? Beeptodriver { get; set; }
        /// <summary>
        /// wykonaj procedurę składowaną
        /// </summary>
        public string Execprocedure { get; set; }
        /// <summary>
        /// SQL z warunkiem wysyłki Msg_ToBase (jeśli wynik pusty - nie wysyłaj)
        /// </summary>
        public string SqlCondition { get; set; }
    }
}
