using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpCheckPointInfo
    {
        public int IdTmpCheckPointInfo { get; set; }
        public Guid? Guid { get; set; }
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// -1-nieznany /0-false /1-true
        /// </summary>
        public int? InfoActionType { get; set; }
        /// <summary>
        /// -1-nieznany /0-false /1-true
        /// </summary>
        public int? InfoDefaultResult { get; set; }
        /// <summary>
        /// 0-cpikunknown /silentOK /2-info /3-warning /4-lock /5-silentError /6-infoError /7-warningError
        /// </summary>
        public int? InfoKind { get; set; }
        /// <summary>
        /// (0/1) PK uruchomiony w trybie &quot;cichym&quot; (bez komunikatów)
        /// </summary>
        public int? InSilentMode { get; set; }
        /// <summary>
        /// id punktu kontrolnego
        /// </summary>
        public int? InCheckPointId { get; set; }
        /// <summary>
        /// id sesji dla tabel TMP
        /// </summary>
        public int? InSessionId { get; set; }
        /// <summary>
        /// PK.param: id kontrahenta
        /// </summary>
        public int? InClientId { get; set; }
        /// <summary>
        /// PK.param: typ 1 obiektu wg standardu statusowego: 1 - przesyłki, 2 zlecenia ftl etc
        /// </summary>
        public int? InObjType1 { get; set; }
        /// <summary>
        /// PK.param: id 1 obiektu
        /// </summary>
        public int? InObjId1 { get; set; }
        /// <summary>
        /// PK.param: typ 2 obiektu wg standardu statusowego: 1 - przesyłki, 2 zlecenia ftl etc
        /// </summary>
        public int? InObjType2 { get; set; }
        /// <summary>
        /// PK.param: id 2 obiektu
        /// </summary>
        public int? InObjId2 { get; set; }
        /// <summary>
        /// PK.wynik: numer błędu
        /// </summary>
        public int? OutErrorNo { get; set; }
        /// <summary>
        /// PK.wynik: tekst błędu/ostrzeżenia/informacji
        /// </summary>
        public string OutErrorText { get; set; }
        /// <summary>
        /// PK.wynik: kod wymaganej zgody
        /// </summary>
        public string OutApprovalCode { get; set; }
        /// <summary>
        /// PK.wynik: info do wymaganej zgody
        /// </summary>
        public string OutApprovalInfo { get; set; }
        /// <summary>
        /// PK.wynik: kod blokady
        /// </summary>
        public string OutLockTypeCode { get; set; }
        /// <summary>
        /// PK.wynik: id blokady
        /// </summary>
        public int? OutLockId { get; set; }
        /// <summary>
        /// PK.wynik: 
        /// </summary>
        public int? OutColor { get; set; }
        /// <summary>
        /// PK.wynik: zatw. zbiorcze - stan
        /// </summary>
        public int? OutState { get; set; }
        /// <summary>
        /// PK.wynik: zatw. zbiorcze - akcja (0/1)
        /// </summary>
        public int? OutAction { get; set; }
        /// <summary>
        /// PK.wynik: rezultat (-1-nieznany /0-false /1-true)
        /// </summary>
        public int? OutResult { get; set; }
        /// <summary>
        /// (0/1)
        /// </summary>
        public int? VarApplyToNext { get; set; }
        public int? VarLockType { get; set; }
        /// <summary>
        /// id typu blokady
        /// </summary>
        public int? VarLockTypeId { get; set; }
        public int? VarLockRightsOk { get; set; }
        /// <summary>
        /// (0/1)
        /// </summary>
        public int? VarRunAfterExecuteSp { get; set; }
        /// <summary>
        /// (-1/0/1)
        /// </summary>
        public int? VarSilentResult { get; set; }
        /// <summary>
        /// (0/1)
        /// </summary>
        public int? VarSummaryConfirmation { get; set; }
    }
}
